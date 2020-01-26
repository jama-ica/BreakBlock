using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Device
{

	/// <summary>
	/// 
	/// </summary>
	public class MouseDevice
	{
		
		// Constructor
		public MouseDevice()
		{
		}

		public EButtonState GetButtonState(EMouseButton button)
		{
			int buttonNo = (int)button;
			if(UnityEngine.Input.GetMouseButtonDown(buttonNo))
			{
				return EButtonState.DOWN;
			}
			else if(UnityEngine.Input.GetMouseButtonUp(buttonNo))
			{
				return EButtonState.UP;
			}
			else if(UnityEngine.Input.GetMouseButton(buttonNo))
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}

		public EButtonState GetButtonState(KeyCode keyCode)
		{
			Assert.IsTrue(KeyCode.Mouse0 <= keyCode && keyCode <= KeyCode.Mouse6);

			if(UnityEngine.Input.GetKeyDown(keyCode))
			{
				return EButtonState.DOWN;
			}
			else if(UnityEngine.Input.GetKeyUp(keyCode))
			{
				return EButtonState.UP;
			}
			else if (UnityEngine.Input.GetKey(keyCode) )
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}

		public (float x, float y) GetMoving()
		{
			return (UnityEngine.Input.GetAxis("Mouse X"), UnityEngine.Input.GetAxis("Mouse Y"));
		}

		public (float x, float y) GetPos()
		{
			return (UnityEngine.Input.mousePosition.x, UnityEngine.Input.mousePosition.y);
		}
		
	}
}
