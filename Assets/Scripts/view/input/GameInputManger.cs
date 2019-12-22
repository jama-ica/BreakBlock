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
		readonly KeySettingData keySettingData;
		GameInput currentGameInput;
		InputDeviceManager inputDeviceMng;
		
		// Constructor
		public GameInputManager(KeySettingData keySettingData)
		{
			this.keySettingData = keySettingData;
			this.currentGameInput = new GameInput();
			this.inputDeviceMng = new InputDeviceManager();
		}

		public void Init()
		{
		}

		public void Update()
		{
			// Cursor
			MouseInput mouse = inputDeviceMng.mouse;
			this.currentGameInput.updateCursorPos(mouse.getPos());
			this.currentGameInput.updateCursorMoving(mouse.getMoving());

			// Button
			Keyboard keyboard = inputDeviceManager.getKeyboard();
			KeyCode[] keyPairs = this.keySettingData.getKeyPairs();
			for(int i = 0 ; i < keyPairs.Length ; i++)
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
