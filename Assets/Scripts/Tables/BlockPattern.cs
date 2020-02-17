using MasterMemory;
using MessagePack;

namespace RLTPS.LevelData
{
	public class BlockPattern {

		public int Width { get; set; }

		public int Height { get; set; }

		public BlockData[] Blocks { get; set; }

	}
}