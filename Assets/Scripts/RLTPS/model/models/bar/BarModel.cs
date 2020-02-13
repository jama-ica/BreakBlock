using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BarModel
	{
		float _speed;

		// Constructor
		public BarModel(float speed)
		{
			this._speed = speed;
		}

		public float Speed { get{ return this._speed; } }


		
	}
}