using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BarComponent : IGameDataComponent
	{
		readonly BarData barData;

		// Constructor
		public BarComponent()
		{
			this.barData = new BarData();
		}

		public IBar Data { get { return this.barData; } }


		public override void LoadFromMasterData(MasterData masterData)
		{
			this.barData.SetSpeed( masterData.GetBarSpeed() );
		}

		public override void LoadFromConfigData(ConfigData configData)
		{

		}

		public override void LoadFromSaveData(SaveData saveData)
		{

		}
		
	}
}