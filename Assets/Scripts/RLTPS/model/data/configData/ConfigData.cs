using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class ConfigData
	{
		
		public KeyConfigData KeyData { get; }

		// Constructor
		public ConfigData()
		{
			this.KeyData = new KeyConfigData();
		}


	}
}
