using MasterMemory;
using MessagePack;

namespace RLTPS.LevelData
{
	[MemoryTable ("BlockData"), MessagePackObject (true)]
	public class BlockData {

		public int X { get; set; }

		public int Y { get; set; }

		public int Hp { get; set; }

	}
}