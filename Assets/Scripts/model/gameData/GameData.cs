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

		public readonly BarComponent BarComp { get; }

		// Constructor
		public GameData()
		{
			this.BarComp = new BarComponent();
		}

		public override readonly IBarData Bar { get { return this.BarComp.Data; } }


		
	}
}
