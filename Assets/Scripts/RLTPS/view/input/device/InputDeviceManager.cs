using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View
{
	/// <summary>
	/// 
	/// </summary>
	public class InputDeviceManager
	{
		public KeyboardInput Keyboard { get; }
		public MouseInput Mouse { get; }
		public GamePadInput GamePad { get; }
		
		// Constructor
		public InputDeviceManager()
		{
			this.Keyboard = new KeyboardInput();
			this.Mouse = new MouseInput();
			this.GamePad = new GamePadInput();
		}

		public void Init()
		{

		}

		
		
	}
}