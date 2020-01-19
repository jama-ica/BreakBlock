using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class GameModel // for Ball
	{
		

		public BarModel CreateBall()
		{
			//TODO
			return new BarModel();
		}

		public float GetBarSpeed()
		{
			return this.GameData.BarData.Speed;
		}

	}
}
