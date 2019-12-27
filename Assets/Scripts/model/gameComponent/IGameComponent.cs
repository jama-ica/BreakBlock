using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class IGameComponent
	{
		public abstract void LoadFromMasterData(MasterData masterData);
		public abstract void LoadFromConfigData(RLTPS.Model.ConfigData configData);
		public abstract void LoadFromSaveData(RLTPS.Model.SaveData saveData);
		
	}
}