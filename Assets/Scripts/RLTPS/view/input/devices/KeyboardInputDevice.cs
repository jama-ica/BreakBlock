using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.View.Device;

namespace RLTPS.View.Input
{
	/// <summary>
	/// 
	/// </summary>
	public class KeyboardInputDevice
	{
		
		readonly KeyboardDevice keyboard;

		// Constructor
		public KeyboardInputDevice(KeyboardDevice keyboard)
		{
			this.keyboard = keyboard;
		}

		public void UpdateInput(ref GameInput gameInput, KeyConfigData keyConfigData)
		{
			KeyCode[] keyPairs = keyConfigData.KeyPairs;
			for(int i = 0 ; i < keyPairs.Length ; i++)
			{
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Backspace > keyCode || keyCode > KeyCode.Menu ){
					continue;
				}
				EButtonState keyState = this.keyboard.GetKeyState(keyCode);
				gameInput.UpdateButtonState((EGameInput)i, keyState);
			}
		}
		
	}
}