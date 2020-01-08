using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class ModelFacade // for Ball
	{
		

		public BarComponent CreateBall()
		{
			//TODO
			return new BallComponent();
		}

		public float GetBarSpeed()
		{
			return this.GameData.BarData.Speed;
		}

	}
}
