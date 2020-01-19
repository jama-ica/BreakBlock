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

		public void updateButtonState(EGameInput type, EButtonState buttonState)
		{
			this.buttonStates[(int)type] = buttonState;
		}

		public void updateCursorPos((float x, float y) pos)
		{
			this.cursorPos = pos;
		}

		public void updateCursorMoving((float x, float y) moving)
		{
			this.cursorMoving = moving;
		}

		/**
		 *	Button state
		 */
		public EButtonState getButtonState(EGameInput type)
		{
			return this.buttonStates[(int)type];
		}

		public bool isButtonState(EGameInput type, EButtonState buttonState)
		{
			return (this.buttonStates[(int)type] == buttonState);
		}

		public bool isTriggerOn(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.DOWN);
		}

		public bool isTriggerOff(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.UP);
		}

		public bool isOn(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.PRESS || this.buttonStates[(int)type] == EButtonState.DOWN);
		}

		public bool isOff(EGameInput type)
		{
			return (this.buttonStates[(int)type] == EButtonState.IDLE || this.buttonStates[(int)type] == EButtonState.UP);
		}

		/**
		 *	Cursor
		 */
		public (float x, float y) getCursorPos()
		{
			return this.cursorPos;
		}

		public (float x, float y) getCursorMoving()
		{
			return this.cursorMoving;
		}
		
	}
}
