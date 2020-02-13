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
		int width;
		int height;
		UtilArray<BlockModel> blocks;

		// Constructor
		public BlockModels(int width, int height)
		{
			ReSize(width, height);
		}

		public EBlockID SetBlock(int x, int y, BlockModel block)
		{
			int index = x + y * this.width;
			this.blocks.Set(index, block);
			return (EBlockID)index;
		}

		public BlockModel GetBlock(EBlockID id)
		{
			return blocks.Get((int)id);
		}

		public void Clear()
		{
			this.width = 0;
			this.height = 0;
			this.blocks.Clear();
		}

		public void ReSize(int width, int height)
		{
			this.width = width;
			this.height = height;
			int size = width * height;
			this.blocks.ReSize(size);
		}

	}
}