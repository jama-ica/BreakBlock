using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class KeyConfigData
	{
		
		public KeyCode[] KeyPairs { get; }

		// Constructor
		public KeyConfigData()
		{
			this.KeyPairs = new KeyCode[(int)EGameInput.MAX];
		}

		public void SetKeyPair(EGameInput gameInput, KeyCode keyCode)
		{
			this.KeyPairs[(int)gameInput] = keyCode;
		}

		public KeyCode GetKeyCode(EGameInput gameInput)
		{
			return this.KeyPairs[(int)gameInput];
		}

	}
}