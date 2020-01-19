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
			: base(0.0f)
		{
		}

		public void SetSpeed(float speed)
		{
			this.Speed = speed;
		}



	}
}