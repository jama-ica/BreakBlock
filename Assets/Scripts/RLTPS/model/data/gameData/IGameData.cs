using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class IGameData
	{
		public abstract IBarData BarData { get; }

		
	}
}