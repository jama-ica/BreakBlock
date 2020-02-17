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
		public BarModel()
		{
			this._speed = 0.0f;
		}


		public void Init(float speed)
		{
			this._speed = speed;
		}

		public float Speed{ get{ return this._speed; } }
		
		
	}
}