using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BallComponent : IGameComponent
	{
		public BallData Data { get; }

		// Constructor
		public BallComponent()
		{
			this.Data = new BallData();
		}

		public override void LoadFromMasterData(MasterData masterData)
		{
			this.Data.SetSpeed( masterData.GetBallSpeed() );
		}

		public override void LoadFromConfigData(ConfigData configData)
		{

		}

		public override void LoadFromSaveData(SaveData saveData)
		{

		}
		
	}
}