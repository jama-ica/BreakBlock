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
	public class Blocks
	{
		public UtilList<Block> blocks { get; }

		// Constructor
		public Blocks()
		{
			this.blocks = new UtilList<Block>(50);
		}

		public void Add(Block block)
		{
			this.blocks.Add(block);
		}

		
	}
}