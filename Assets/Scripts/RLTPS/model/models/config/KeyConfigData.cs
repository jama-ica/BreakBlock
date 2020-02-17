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

		public static KeyConfigData CreateDefault()
		{
			KeyConfigData data = new KeyConfigData();
			data.SetKeyPair(EGameInput.MoveRight, KeyCode.RightArrow);
			data.SetKeyPair(EGameInput.MoveLeft, KeyCode.LeftArrow);
			return data;
		}


		[Key(0)]
		public KeyCode[] KeyPairs { get; set; }

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

		public void CopyFrom(KeyConfigData keyData)
		{
			for(int i = 0 ; i < this.KeyPairs.Length ; i++)
			{
				EGameInput gameInput = (EGameInput)i;
				this.SetKeyPair(gameInput, keyData.GetKeyCode(gameInput));
			}
		}

	}
}