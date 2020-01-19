using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class KeyboardInput
	{
		
		// Constructor
		public KeyboardInput()
		{
		}

		public EButtonState getKeyState(KeyCode keyCode)
		{
			Assert.IsTrue(KeyCode.Backspace <= keyCode && keyCode <= KeyCode.Menu);

			if(Input.GetKeyDown(keyCode))
			{
				return EButtonState.DOWN;
			}
			else if(Input.GetKeyUp(keyCode))
			{
				return EButtonState.UP;
			}
			else if (Input.GetKey(keyCode))
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}
		
	}
}
