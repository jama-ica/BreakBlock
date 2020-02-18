using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BallModel
	{
		float _speed;

		// Constructor
		public BallModel(float speed)
		{
			this._speed = speed;
		}

		public float Speed{ get{ return this._speed; } }
		
	}
}