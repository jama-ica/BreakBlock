using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class MouseInput
	{
		
		// Constructor
		public MouseInput()
		{
		}

		public EButtonState getButtonState(EMouseButton button)
		{
			int buttonNo = (int)button;
			if(Input.GetMouseButtonDown(buttonNo))
			{
				return EButtonState.DOWN;
			}
			else if(Input.GetMouseButtonUp(buttonNo))
			{
				return EButtonState.UP;
			}
			else if(Input.GetMouseButton(buttonNo))
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}

		public EButtonState getButtonState(KeyCode keyCode)
		{
			Assert.IsTrue(KeyCode.Mouse0 <= keyCode && keyCode <= KeyCode.Mouse6);

			if(Input.GetKeyDown(keyCode))
			{
				return EButtonState.DOWN;
			}
			else if(Input.GetKeyUp(keyCode))
			{
				return EButtonState.UP;
			}
			else if ( Input.GetKey(keyCode) )
			{
				return EButtonState.PRESS;
			}
			return EButtonState.IDLE;
		}

		public (float x, float y) getMoving()
		{
			return (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		}

		public (float x, float y) getPos()
		{
			return (Input.mousePosition.x, Input.mousePosition.y);
		}
		
	}
}
