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
			var list = new List<(KeyCode keyCode, EGameInput gameInputType)>();
			KeyCode[] keyPairs = keyConfig.KeyPairs;

			for(int i = 0 ; i < keyPairs.Length ; i++){
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Backspace > keyCode || keyCode > KeyCode.Menu ){
					continue;
				}
				list.Add((keyCode, (EGameInput)i));
			}
			// list to keyMap
			this.keyMap = list.ToArray();
		}

		public void UpdateInput(ref GameInput gameInput)
		{
			Assert.IsTrue(this.keyMap.Length > 0);
			for(int i = 0 ; i < this.keyMap.Length ; i++)
			{
				EButtonState keyState = this.keyboard.GetKeyState(this.keyMap[i].keyCode);
				gameInput.UpdateButtonState(this.keyMap[i].gameInputType, keyState);
			}
		}
		
	}
}