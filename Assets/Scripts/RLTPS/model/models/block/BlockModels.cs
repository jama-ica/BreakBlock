using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;
using RLTPS.LevelData;

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
		public BlockModels()
		{
			this.width = 0;
			this.height = 0;
			this.blocks = new UtilArray<BlockModel>(0);
		}

		public void Init(BlockPattern blockPattern)
		{
			//TODO
		}

		public BlockModel GetBlock(EBlockID id)
		{
			return blocks.Get((int)id);
		}

		EBlockID SetBlock(int x, int y, BlockModel block)
		{
			int index = x + y * this.width;
			this.blocks.Set(index, block);
			return (EBlockID)index;
		}

		void Clear()
		{
			this.width = 0;
			this.height = 0;
			this.blocks.Clear();
		}

		void ReSize(int width, int height)
		{
			this.width = width;
			this.height = height;
			int size = width * height;
			this.blocks.ReSize(size);
		}

	}
}