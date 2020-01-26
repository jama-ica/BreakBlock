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
	public class InputManager
	{
		readonly KeyboardInputDevice keyboard;
		readonly MouseInputDevice mouse;
		/*readonly*/ KeyConfigData keyConfigData;
		//--
		GameInput currentGameInput;
		
		// Constructor
		public InputManager(DeviceManager deviceMng)
		{
			this.keyboard = new KeyboardInputDevice(deviceMng.Keyboard);
			this.mouse = new MouseInputDevice(deviceMng.Mouse);
			this.currentGameInput = new GameInput();
		}

		public void Init(KeyConfigData keyConfigData)
		{
			this.keyConfigData = keyConfigData;
		}

		public void Update()
		{
			this.mouse.UpdateInput(ref currentGameInput, this.keyConfigData);
			this.keyboard.UpdateInput(ref currentGameInput, this.keyConfigData);
		}

		public GameInput GetCurrentGameInput()
		{
			return this.currentGameInput;
		}

	}
}
