using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class GameInput
	{
		EButtonState[] buttonStates;
		(float x, float y) cursorPos;
		(float x, float y) cursorMoving;
		
		// Constructor
		public GameInput()
		{
			this.buttonStates = new EButtonState[(int)EGameInput.MAX];
			this.cursorPos = (0.0f, 0.0f);
			this.cursorMoving = (0.0f, 0.0f);
		}

		public void UpdateButtonState(EGameInput type, EButtonState buttonState)
		{
			this.buttonStates[(int)type] = buttonState;
		}

		public void UpdateCursorPos((float x, float y) pos)
		{
			this.cursorPos = pos;
		}

		public void UpdateCursorMoving((float x, float y) moving)
		{
			this.cursorMoving = moving;
		}

		/**
		 *	Button state
		 */
		public EButtonState GetButtonState(EGameInput type)
		{
			return this.buttonStates[(int)type];
		}

		public bool IsButtonState(EGameInput type, EButtonState buttonState)
		{
			return (this.buttonStates[(int)type] == buttonState);
		}

		public bool IsTriggerOn(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.DOWN);
		}

		public bool IsTriggerOff(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.UP);
		}

		public bool IsOn(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.PRESS || this.buttonStates[(int)type] == EButtonState.DOWN);
		}

		public bool IsOff(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.IDLE || this.buttonStates[(int)type] == EButtonState.UP);
		}

		/**
		 *	Cursor
		 */
		public (float x, float y) GetCursorPos()
		{
			return this.cursorPos;
		}

		public (float x, float y) GetCursorMoving()
		{
			return this.cursorMoving;
		}
		
	}
}
