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
		public BarComponent BarComponent { get; }

		// Constructor
		public GameData()
		{
			this.BarComponent = new BarComponent();
		}

		public override IBarData BarData { get => this.BarComponent.Data; }


	}
}
