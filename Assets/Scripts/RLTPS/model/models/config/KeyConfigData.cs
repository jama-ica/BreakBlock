using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using MessagePack;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	[MessagePackObject]
	public class KeyConfigData
	{
		[Key(0)]
		public KeyCode[] KeyPairs { get; set; }

		// Constructor
		public KeyConfigData()
		{
			this.KeyPairs = new KeyCode[(int)EGameInput.MAX];
			this.KeyPairs[(int)EGameInput.MoveRight] = KeyCode.RightArrow;
			this.KeyPairs[(int)EGameInput.MoveLeft] = KeyCode.LeftArrow;
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