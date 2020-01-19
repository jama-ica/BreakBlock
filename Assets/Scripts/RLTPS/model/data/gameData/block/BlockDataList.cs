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
		public UtilArray<BlockData> blocks { get; protected set; }

		// Constructor
		public Blocks()
		{
			this.blocks = new UtilArray<BlockData>(50);
		}

		public void Add(BlockData block)
		{
			this.blocks.Add(block);
		}

		
	}
}