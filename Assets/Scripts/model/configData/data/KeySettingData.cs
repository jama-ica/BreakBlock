using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class KeySettingData
	{
		
		public KeyCode[] keyPairs { get; }

		// Constructor
		public KeySettingData()
		{
			this.keyPairs = new KeyCode[(int)EGameInput.MAX];
		}

		public void setKeyPair(EGameInput gameInput, KeyCode keyCode)
		{
			this.keyPairs[(int)gameInput] = keyCode;
		}

		public KeyCode getKeyCode(EGameInput gameInput)
		{
			return this.keyPairs[(int)gameInput];
		}

	}
}