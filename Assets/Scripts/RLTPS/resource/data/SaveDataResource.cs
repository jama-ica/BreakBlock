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
		
	 	string SaveDirectory { get { return $"{Application.dataPath}/Data"; } }

		string SaveFileName { get { return "save.dat"; } }

		string SaveFilePath { get { return $"{this.SaveDirectory}/{this.SaveFileName}"; } }
		

		// Constructor
		public SaveDataResource()
		{
		}

		public SaveData Load()
		{
			SaveData saveData = null;
			try {
				var filePath = this.SaveFilePath;
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
			Directory.CreateDirectory(this.SaveDirectory);

			var bytes = MessagePackSerializer.Serialize (saveData);

			var filePath = this.SaveFilePath;
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
