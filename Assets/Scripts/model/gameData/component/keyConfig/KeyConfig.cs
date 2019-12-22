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
		
		public KeyCode[] keyCodes { get; }

		// Constructor
		public KeyConfig()
		{
			this.keyCodes = new KeyCode[(int)EGameInput.MAX];
		}

		public void SetKeyCode(EGameInput type, KeyCode code)
		{
			this.keyCodes[(int)type] = code;
		}

		public KeyCode GetKeyCode(EGameInput type)
		{
			return this.keyPairs[(int)type];
		}

		public int Length()
		{
			return this.keyCodes.Length;
		}

	}
}