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

		static readonly string ConfigDirectory = $"{Application.dataPath}/Data";

		static readonly string ConfigFileName = "config.dat";

		static readonly string ConfigFilePath = $"{ConfigDataResource.ConfigDirectory}/{ConfigDataResource.ConfigFileName}";
		
		// Constructor
		public ConfigDataResource()
		{
		}


		public ConfigData Load()
		{
			ConfigData configData = null;
			try {
				var filePath = ConfigDataResource.ConfigFilePath;
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
			Directory.CreateDirectory(ConfigDataResource.ConfigFilePath);

			var bytes = MessagePackSerializer.Serialize(configData);

			var filePath = ConfigDataResource.ConfigFilePath;
			using (var fs = new FileStream(filePath, FileMode.Create)) {
				fs.Write (bytes, 0, bytes.Length);
			}
			return true;
		}

		ConfigData CreateNewConfigData()
		{
			//TODO
			return new ConfigData();
		}
		
		
	}
}
