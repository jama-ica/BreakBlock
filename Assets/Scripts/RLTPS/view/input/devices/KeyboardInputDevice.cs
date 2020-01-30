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
		Dictionary<int, EGameInput> keyMap;

		// Constructor
		public KeyboardInputDevice(KeyboardDevice keyboard)
		{
			this.keyboard = keyboard;
			this.keyMap = new Dictionary<int, EGameInput>();
		}

		public void InitKeyConfig(KeyConfigData keyConfigData)
		{
			this.keyMap.Clear();
			foreach(KeyValuePair<int, EGameInput> item in keyConfigData.KeyMap)
			{
				int keyCode = item.Key;
				if( (int)KeyCode.Backspace > keyCode || keyCode > (int)KeyCode.Menu ){
					continue;
				}
				this.keyMap[keyCode] = item.Value;
			}
		}

		public void UpdateInput(ref GameInput gameInput)
		{
			foreach(KeyValuePair<int, EGameInput> item in this.keyMap)
			{
				KeyCode keyCode = (KeyCode)item.Key;
				EButtonState keyState = this.keyboard.GetKeyState(keyCode);
				gameInput.UpdateButtonState(item.Value, keyState);
			}
		}
		
	}
}