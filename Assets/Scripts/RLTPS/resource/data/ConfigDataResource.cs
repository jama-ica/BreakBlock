using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Assertions;
using MessagePack;
using RLTPS.Model;

namespace RLTPS.Resource
{

	/// <summary>
	/// 
	/// </summary>
	public class ConfigDataResource
	{

		string ConfigDirectory { get{ return $"{Application.dataPath}/Data"; } }

		string ConfigFileName { get { return "config.dat";} }

		string ConfigFilePath { get { return $"{this.ConfigDirectory}/{this.ConfigFileName}"; } }
		
		// Constructor
		public ConfigDataResource()
		{
		}

		public ConfigData Load()
		{
			ConfigData configData = null;
			try {
				var filePath = this.ConfigFilePath;
				using (var fs = new FileStream (filePath, FileMode.Open, FileAccess.Read)) {
					byte[] bytes = new byte[fs.Length];
					fs.Read (bytes, 0, bytes.Length);
					configData = MessagePackSerializer.Deserialize<ConfigData> (bytes);
				}
			} catch {
				configData = CreateNewConfigData();
			}
			return configData;
		}

		public bool Save(ConfigData configData)
		{
			Directory.CreateDirectory(this.ConfigDirectory);

			var bytes = MessagePackSerializer.Serialize(configData);

			var filePath = this.ConfigFilePath;
			using (var fs = new FileStream(filePath, FileMode.Create)) {
				fs.Write (bytes, 0, bytes.Length);
			}
			return true;
		}

		ConfigData CreateNewConfigData()
		{
			return ConfigData.CreateDefault();
		}
		
		
	}
}
