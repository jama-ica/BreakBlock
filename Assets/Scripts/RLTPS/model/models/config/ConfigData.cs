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
		
		public static ConfigData CreateDefault()
		{
			var keyData = KeyConfigData.CreateDefault();
			var configData = new ConfigData(keyData);
			return configData;
		}

		KeyConfigData _keyData;

		// Constructor
		public ConfigData(KeyConfigData keyData)
		{
			this._keyData = keyData;
		}

		public ConfigData()
			: this(new KeyConfigData())
		{
		}

		public KeyConfigData KeyData { get{ return this._keyData; } }

		public void CopyFrom(ConfigData configData)
		{
			this._keyData.CopyFrom(configData.KeyData);
		}

	}
}
