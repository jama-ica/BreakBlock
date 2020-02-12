using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Device;

namespace RLTPS.View.Input
{
	/// <summary>
	/// 
	/// </summary>
	public class MouseInputDevice
	{
		(KeyCode keyCode, EGameInput gameInputType)[] keyMap;
		MouseDevice mouse;
		
		// Constructor
		public MouseInputDevice(MouseDevice mouse)
		{
			this.keyMap = new (KeyCode keyCode, EGameInput gameInputType)[0];
			this.mouse = mouse;
		}

		public void InitKeyConfig(KeyConfigData keyConfig)
		{
			KeyCode[] keyPairs = keyConfig.KeyPairs;
			//TODO this.keyMap = new (KeyCode keyCode, EGameInput gameInputType)[keyPairs.Length];//TODO resize

			for(int i = 0 ; i < keyPairs.Length ; i++){
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Mouse0 > keyCode || keyCode > KeyCode.Mouse6 ){
					continue;
				}
				this.keyMap[i] = (keyCode, (EGameInput)i);
			}
		}

		public void UpdateInput(ref GameInput gameInput)
		{
			// Cursor
			gameInput.UpdateCursorPos(this.mouse.GetPos());
			gameInput.UpdateCursorMoving(this.mouse.GetMoving());

			for(int i = 0 ; i < this.keyMap.Length ; i++)
			{
				EButtonState buttonState = this.mouse.GetButtonState(this.keyMap[i].keyCode);
				gameInput.UpdateButtonState((EGameInput)i, buttonState);
			}

		}
		
	}
}