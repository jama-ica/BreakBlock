using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class IBarData
	{
		public float Speed { get; protected set; }

		public IBarData(float Speed)
		{
			this.Speed = Speed;
		}
		
	}
}