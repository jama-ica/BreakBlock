using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class GameModel // for Bar
	{
		
		public BarModel Bar { get; private set; }

		public BarModel CreateBar()
		{
			if(this.Bar == null){
				this.Bar = new BarModel();
			}
			return this.Bar;
		}

	}
}
