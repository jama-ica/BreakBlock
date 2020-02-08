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
	public class KeyboardInputDevice
	{
		(KeyCode keyCode, EGameInput gameInputType)[] keyMap;
		readonly KeyboardDevice keyboard;

		// Constructor
		public KeyboardInputDevice(KeyboardDevice keyboard)
		{
			this.keyMap = new (KeyCode keyCode, EGameInput gameInputType)[0];
			this.keyboard = keyboard;
		}

		public void InitKeyConfig(KeyConfigData keyConfig)
		{
			KeyCode[] keyPairs = keyConfig.KeyPairs;
			this.keyMap = new (KeyCode keyCode, EGameInput gameInputType)[keyPairs.Length];

			for(int i = 0 ; i < keyPairs.Length ; i++){
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Backspace > keyCode || keyCode > KeyCode.Menu ){
					continue;
				}
				this.keyMap[i] = (keyCode, (EGameInput)i);
			}
		}

		public void UpdateInput(ref GameInput gameInput)
		{
			for(int i = 0 ; i < this.keyMap.Length ; i++)
			{
				EButtonState keyState = this.keyboard.GetKeyState(this.keyMap[i].keyCode);
				gameInput.UpdateButtonState(this.keyMap[i].gameInputType, keyState);
			}
		}
		
	}
}