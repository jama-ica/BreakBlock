using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class GameDataComponentPool
	{
		public UtilArray<IGameDataComponent> AllComps{ get; }

		public BarComponent BarComp { get; }
		public UtilArray<BlockComponent> BlockComps { get; }
		
		// Constructor
		public GameDataComponentPool()
		{
			this.AllComps = new UtilArray<IGameDataComponent>(100);
		}

		public BarComponent SetBarComp(BarComponent barComp)
		{
			//this.
		}

		
	}
}