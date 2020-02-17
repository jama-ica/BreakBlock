using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.LevelData;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class MasterData
	{
		public static MasterData CreateDefault()
		{
			//TODO
			return new RLTPS.Model.MasterData();
		}

		GameStage _stage;

		// Constructor
		public MasterData()
		{
			this._stage = null;
		}

		public GameStage Stage { get { return this._stage; } }

		public void Init(GameStage stage)
		{
			this._stage = stage;
		}

		public void CopyFrom(MasterData masterData)
		{
			//TODO
		}
		
	}
}