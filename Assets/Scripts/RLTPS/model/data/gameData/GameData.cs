using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class GameData : IGameData
	{
		public BarModel BarModel { get; }

		// Constructor
		public GameData()
		{
			this.BarModel = new BarModel();
		}

		public override IBarData BarData { get => this.BarModel.Data; }


	}
}
