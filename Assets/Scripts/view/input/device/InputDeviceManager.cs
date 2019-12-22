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
		public KeyboardInput keyboard { get; }
		public MouseInput mouse { get; }
		public GamePadInput gamePad { get; }
		
		// Constructor
		public InputDeviceManager()
		{
			this.keyboard = new KeyboardInput();
			this.mouse = new MouseInput();
			this.gamePad = new GamePadInput();
		}

		public void Init()
		{

		}

		
		
	}
}