using UnityEngine;
using UnityEngine.Assertions;
using MasterMemory;
using MessagePack;

namespace RLTPS.LevelData
{
	[MemoryTable ("BlockPattern"), MessagePackObject (true)]
	public class BlockPattern {

		public int Width { get; set; }

		public int Height { get; set; }

		public BlockData[] Blocks { get; set; }

		public BlockData GetBlockData(int index)
		{
			Assert.IsTrue(0 <= index && index < Blocks.Length);
			return this.Blocks[index];
		}

	}
}