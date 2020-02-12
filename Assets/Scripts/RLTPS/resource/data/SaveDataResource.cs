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
	public class SaveDataResource
	{
		
		static readonly string SaveDirectory = $"{Application.dataPath}/Data";

		static readonly string SaveFileName = "save.dat";

		static readonly string SaveFilePath = $"{SaveDataResource.SaveDirectory}/{SaveDataResource.SaveFileName}";
		

		// Constructor
		public SaveDataResource()
		{
		}

		public SaveData Load()
		{
			SaveData saveData = null;
			try {
				var filePath = SaveDataResource.SaveFilePath;
				using (var fs = new FileStream (filePath, FileMode.Open, FileAccess.Read)) {
					byte[] bytes = new byte[fs.Length];
					fs.Read (bytes, 0, bytes.Length);
					saveData = MessagePackSerializer.Deserialize<SaveData> (bytes);
				}
			} catch {
				saveData = CreateNewSaveData ();
			}
			return saveData;
		}

		public bool Save(SaveData saveData)
		{
			Directory.CreateDirectory(SaveDataResource.SaveDirectory);

			var bytes = MessagePackSerializer.Serialize (saveData);

			var filePath = SaveDataResource.SaveFilePath;
			using (var fs = new FileStream(filePath, FileMode.Create)) {
				fs.Write (bytes, 0, bytes.Length);
			}
			return true;
		}

		SaveData CreateNewSaveData()
		{
			//TODO
			return new SaveData();
		}


	}
}
