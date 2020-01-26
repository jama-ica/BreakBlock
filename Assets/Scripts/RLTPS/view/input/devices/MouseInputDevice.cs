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
		
		// Constructor
		public MouseInputDevice(MouseDevice mouse)
		{
			this.mouse = mouse;
		}

		public void UpdateInput(ref GameInput gameInput, KeyConfigData keyConfigData)
		{
			// Cursor
			gameInput.UpdateCursorPos(this.mouse.GetPos());
			gameInput.UpdateCursorMoving(this.mouse.GetMoving());

			KeyCode[] keyPairs = keyConfigData.KeyPairs;
			for(int i = 0 ; i < (int)EGameInput.MAX ; i++)
			{
				KeyCode keyCode = keyPairs[i];
				if( KeyCode.Mouse0 > keyCode && keyCode > KeyCode.Mouse6 ){
					continue;
				}
				// mouse
				EButtonState buttonState = mouse.GetButtonState(keyCode);
				gameInput.UpdateButtonState((EGameInput)i, buttonState);
			}

		}
		
	}
}