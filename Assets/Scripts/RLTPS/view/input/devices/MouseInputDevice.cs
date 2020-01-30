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
	public class MouseInputDevice
	{
		MouseDevice mouse;
		Dictionary<int, EGameInput> keyMap;

		// Constructor
		public MouseInputDevice(MouseDevice mouse)
		{
			this.mouse = mouse;
			this.keyMap = new Dictionary<int, EGameInput>();
		}

		public void InitKeyConfig(KeyConfigData keyConfigData)
		{
			this.keyMap.Clear();
			foreach(KeyValuePair<int, EGameInput> item in this.keyMap)
			{
				int keyCode = item.Key;
				if( (int)KeyCode.Mouse0 > keyCode && keyCode > (int)KeyCode.Mouse6 ){
					continue;
				}
				this.keyMap[keyCode] = item.Value;
			}
		}

		public void UpdateInput(ref GameInput gameInput)
		{
			// Cursor
			gameInput.UpdateCursorPos(this.mouse.GetPos());
			gameInput.UpdateCursorMoving(this.mouse.GetMoving());

			// Button
			foreach(KeyValuePair<int, EGameInput> item in this.keyMap)
			{
				KeyCode keyCode = (KeyCode)item.Key;
				EButtonState keyState = this.mouse.GetButtonState(keyCode);
				gameInput.UpdateButtonState(item.Value, keyState);
			}
		}
		
	}
}