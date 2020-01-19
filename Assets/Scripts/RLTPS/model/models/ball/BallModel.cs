using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BallModel
	{
		public BallData Data { get; }

		// Constructor
		public BallModel()
		{
			this.Data = new BallData();
		}

		// public override void LoadFromMasterData(MasterData masterData)
		// {
		// 	this.Data.SetSpeed( masterData.GetBallSpeed() );
		// }

		
	}
}