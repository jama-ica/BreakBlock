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
	public class BlocksModel
	{
		int _width;
		int _height;
		UtilArray<BlockModel> blocks;

		// Constructor
		public BlocksModel(BlockPattern blockPattern)
		{
			this._width = blockPattern.Width;
			this._height = blockPattern.Height;
			int size = this._width * this._height;
			this.blocks = new UtilArray<BlockModel>(size);
			for(int i = 0 ; i < size ; i++)
			{
				BlockData data = blockPattern.GetBlockData(i);
				BlockModel block = new BlockModel((EBlockID)i, data);
				this.blocks.Set(i, block);
			}
		}

		public int Width { get { return this._width; } }

		public int Height { get { return this._height; } }

		public int Size { get { return this._width * this._height; } }

		public BlockModel GetBlock(int index)
		{
			Assert.IsTrue(0 <= index && index < Size);
			return this.blocks.Get(index);
		}

	}
}