using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class IGameDataComponent
	{
		public abstract void LoadFromMasterData(MasterData masterData);
		public abstract void LoadFromConfigData(ConfigData configData);
		public abstract void LoadFromSaveData(SaveData saveData);
		
	}
}