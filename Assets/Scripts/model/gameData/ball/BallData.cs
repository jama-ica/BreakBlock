using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BallData
	{
		public float Speed { get; }

		// Constructor
		public BallData()
		{
		}

		public void SetSpeed(float speed)
		{
			this.Speed = speed;
		}



	}
}