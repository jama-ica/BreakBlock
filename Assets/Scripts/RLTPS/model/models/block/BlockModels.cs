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
	public class BlockModels
	{
		UtilArray<BlockModel> blocks;

		// Constructor
		public BlockModels()
		{
			this.blocks = new UtilArray<BlockModel>(100);//TODO
		}
		
		public BlockModel GetBlock(EBlockID id)
		{
			return blocks.Get((int)id);
		}
	}
}