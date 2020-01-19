using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class KeyConfig
	{
		
		public KeyCode[] KeyCodes { get; }

		// Constructor
		public KeyConfig()
		{
			this.KeyCodes = new KeyCode[(int)EGameInput.MAX];
		}

		public void SetKeyCode(EGameInput type, KeyCode code)
		{
			this.KeyCodes[(int)type] = code;
		}

		public KeyCode GetKeyCode(EGameInput type)
		{
			return this.KeyCodes[(int)type];
		}

		public int Length()
		{
			return this.KeyCodes.Length;
		}

	}
}