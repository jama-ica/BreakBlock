using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class GameInputManager
	{
		KeyConfigData keyConfigData;
		readonly InputDeviceManager inputDeviceMng;
		//--
		GameInput currentGameInput;
		
		// Constructor
		public GameInputManager(InputDeviceManager inputDeviceMng)
		{
			this.keyConfigData = null;
			this.inputDeviceMng = inputDeviceMng;
			this.currentGameInput = new GameInput();
		}

		public void Init()
		{
		}

		public void Update()
		{
			// Cursor
			MouseInput mouse = inputDeviceMng.Mouse;
			this.currentGameInput.updateCursorPos(mouse.getPos());
			this.currentGameInput.updateCursorMoving(mouse.getMoving());

			// Button
			KeyboardInput keyboard = inputDeviceMng.Keyboard;
			KeyCode[] keyPairs = this.keyConfigData.KeyPairs;
			for(int i = 0 ; i < (int)EGameInput.MAX ; i++)
			{
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Backspace <= keyCode && keyCode <= KeyCode.Menu ){
					// keyboard
					EButtonState keyState = keyboard.getKeyState(keyCode);
					this.currentGameInput.updateButtonState((EGameInput)i, keyState);
				}
				else if( KeyCode.Mouse0 <= keyCode && keyCode <= KeyCode.Mouse6 ){
					// mouse
					EButtonState buttonState = mouse.getButtonState(keyCode);
					this.currentGameInput.updateButtonState((EGameInput)i, buttonState);
				}
			}
		}

		public GameInput getCurrentGameInput()
		{
			return this.currentGameInput;
		}

	}
}
