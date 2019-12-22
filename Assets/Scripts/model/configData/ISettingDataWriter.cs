using System;
using System.Collections.Generic;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public interface ISettingDataWriter
	{
		bool Save(SettingData settingData);
		
	}
}