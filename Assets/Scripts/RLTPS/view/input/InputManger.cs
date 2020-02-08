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
		GameInput currentInput;

		// Constructor
		public InputManager(DeviceManager deviceManager)
		{
			this.keyboard = new KeyboardInputDevice(deviceManager.Keyboard);
			this.mouse = new MouseInputDevice(deviceManager.Mouse);
			this.currentInput = new GameInput();
		}

		public GameInput CurrentInput { get{ return this.currentInput; }}

		public void InitKeyConfig(KeyConfigData keyConfig)
		{
			this.keyboard.InitKeyConfig(keyConfig);
			this.mouse.InitKeyConfig(keyConfig);
		}

		public void Update()
		{
			this.mouse.UpdateInput(ref this.currentInput);
			this.keyboard.UpdateInput(ref this.currentInput);
		}


	}
}
