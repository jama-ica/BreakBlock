
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class GameModel
	{

		ConfigData _configData;
		MasterData _masterData;
		SaveData _saveData;

		GameStageModel _stage;

		// Constructor
		public GameModel()
		{
			this._configData = null;
			this._masterData = null; 
			this._saveData = null; 
			this._stage = null; 
		}

		public void SetMasterData(MasterData masterData)
		{
			Assert.IsNull(this._masterData);
			this._masterData = masterData;
		}

		public void SetConfigData(ConfigData configData)
		{
			Assert.IsNull(this._configData);
			this._configData = configData;
		}

		public void SetSaveData(SaveData saveData)
		{
			Assert.IsNull(this._saveData);
			this._saveData = saveData;
		}

		public void CreateStage()
		{
			this._stage = new GameStageModel();
			this._stage.Create(this._masterData);
		}

		public GameStageModel Stage { get { return this._stage; } }


	}
}
