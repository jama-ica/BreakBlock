using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class ModelFacade // for Bar
	{
		

		public BarComponent CreateBar()
		{
			//TODO
			return new BarComponent();
		}

		public float GetBarSpeed()
		{
			return this.GameData.BarData.Speed;
		}

	}
}
