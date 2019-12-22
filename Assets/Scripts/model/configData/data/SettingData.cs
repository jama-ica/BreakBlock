using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class SettingData
	{
		
		public readonly KeySettingData keySettingData { get; }

		// Constructor
		public SettingData()
		{
			this.keySettingData = new KeySettingData();
		}


	}
}
