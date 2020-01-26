using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Device
{
	/// <summary>
	/// 
	/// </summary>
	public class DeviceManager
	{
		public KeyboardDevice Keyboard { get; }
		public MouseDevice Mouse { get; }
		public GamePadDevice GamePad { get; }
		
		// Constructor
		public DeviceManager()
		{
			this.Keyboard = new KeyboardDevice();
			this.Mouse = new MouseDevice();
			this.GamePad = new GamePadDevice();
		}

	}
}