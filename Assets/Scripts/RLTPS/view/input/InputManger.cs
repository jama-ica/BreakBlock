using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Device;

namespace RLTPS.View.Input
{

	/// <summary>
	/// 
	/// </summary>
	public class InputManager
	{
		KeyboardInputDevice keyboard;
		MouseInputDevice mouse;
		GameInput _currentInput;

		// Constructor
		public InputManager(DeviceManager deviceManager)
		{
			this.keyboard = new KeyboardInputDevice(deviceManager.Keyboard);
			this.mouse = new MouseInputDevice(deviceManager.Mouse);
			this._currentInput = new GameInput();
		}

		public GameInput CurrentInput { get{ return this._currentInput; }}

		public void InitKeyConfig(KeyConfigData keyConfig)
		{
			this.keyboard.InitKeyConfig(keyConfig);
			this.mouse.InitKeyConfig(keyConfig);
		}

		public void Update()
		{
			this.mouse.UpdateInput(ref this._currentInput);
			this.keyboard.UpdateInput(ref this._currentInput);
		}


	}
}
