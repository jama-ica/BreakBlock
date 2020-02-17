
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
			if(this._masterData == null){
				this._masterData = masterData;
			}
			else{
				this._masterData.CopyFrom(masterData);
			}
		}
				
		public void SetConfigData(ConfigData configData)
		{
			if(this._configData == null){
				this._configData = configData;
			}
			else{
				this._configData.CopyFrom(configData);
			}
		}

		public void SetSaveData(SaveData saveData)
		{
			if(this._saveData == null){
				this._saveData = saveData;
			}
			else{
				this._saveData.CopyFrom(saveData);
			}
		}

		public void CreateStage()
		{
			if(this._stage == null){
				this._stage = new GameStageModel();
			}
			this._stage.Init(this._masterData);
		}

		public GameStageModel Stage { get { return this._stage; } }


	}
}
