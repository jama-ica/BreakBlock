using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BarData : IBarData
	{
		
		// Constructor
		public BarData()
		{
			this.Speed = 0.0;
		}

		public void SetSpeed(float speed)
		{
			this.Speed = speed;
		}



	}
}