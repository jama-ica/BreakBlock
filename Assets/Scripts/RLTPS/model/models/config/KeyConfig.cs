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
		
		public KeyConfigData Data { get; }

		// Constructor
		public KeyConfig()
		{
			this.Data = new KeyConfigData();
		}


	}
}