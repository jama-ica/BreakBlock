using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class ModelFacade
	{
		
		public IBarData CreateBar()
		{

		}

		public float GetBarSpeed()
		{
			return this.gameData.Bar.Speed;
		}

	}
}
