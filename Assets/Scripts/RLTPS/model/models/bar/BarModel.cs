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
		readonly BarData barData;

		// Constructor
		public BarModel()
		{
			this.barData = new BarData();
		}

		public IBarData Data { get { return this.barData; } }

		
	}
}