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
		public Dictionary<int, EGameInput> KeyMap { get; private set; }

		// Constructor
		public KeyConfigData()
		{
			this.KeyMap = new Dictionary<int, EGameInput>();
		}

		public void ClearAll()
		{
			this.KeyMap.Clear();
		}

		public void SetPair(KeyCode keyCode, EGameInput gameInput)
		{
			this.KeyMap[(int)keyCode] = gameInput;
		}

	}
}