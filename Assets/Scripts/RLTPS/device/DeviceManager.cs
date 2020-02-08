using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Device
{
	/// <summary>
	/// 
	/// </summary>
	public class DeviceManager
	{
		public KeyboardDevice Keyboard { get; private set; }
		public MouseDevice Mouse { get; private set; }
		public GamePadDevice GamePad { get; private set; }
		
		// Constructor
		public DeviceManager()
		{
			this.Keyboard = new KeyboardDevice();
			this.Mouse = new MouseDevice();
			this.GamePad = new GamePadDevice();
		}

	}
}