using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Device
{

	/// <summary>
	/// 
	/// </summary>
	public class KeyboardDevice
	{
		
		// Constructor
		public KeyboardDevice()
		{
		}

		public EButtonState GetKeyState(KeyCode keyCode)
		{
			Assert.IsTrue(KeyCode.Backspace <= keyCode && keyCode <= KeyCode.Menu);

			if(UnityEngine.Input.GetKeyDown(keyCode))
			{
				return EButtonState.DOWN;
			}
			else if(UnityEngine.Input.GetKeyUp(keyCode))
			{
				return EButtonState.UP;
			}
			else if (UnityEngine.Input.GetKey(keyCode))
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}
		
	}
}
