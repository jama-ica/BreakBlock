using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class GameComponentPool
	{
		public UtilArray<IGameComponent> AllComps{ get; }

		public BarComponent BarComp { get; private set; }
		public UtilArray<BlockComponent> BlockComps { get; }
		
		// Constructor
		public GameComponentPool()
		{
			this.AllComps = new UtilArray<IGameComponent>(100);
		}

		public void SetBarComp(BarComponent barComp)
		{
			this.BarComp = barComp;
		}


	}
}