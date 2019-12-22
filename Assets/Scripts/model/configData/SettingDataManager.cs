using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class SettingDataManager
	{
		public readonly SettingData settingData { get; }
		readonly ISettingDataReader settingDataReader;
		readonly ISettingDataWriter settingDataWriter;
		
		// Constructor
		public SettingDataManager(ISettingDataReader settingDataReader, ISettingDataWriter settingDataWriter)
		{
			this.settingData = new SettingData();
			this.settingDataReader = settingDataReader;
			this.settingDataWriter = settingDataWriter;
		}

		public bool Load()
		{
			SettingData settingData = this.settingDataWriter.Load();
			return this.settingData.copy(settingData);
		}

		public bool Save()
		{
			return this.settingDataWriter.Save(this.settingData);
		}


		
	}
}