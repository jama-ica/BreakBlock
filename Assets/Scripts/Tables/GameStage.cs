using MasterMemory;
using MessagePack;

namespace RLTPS.LevelData
{
	[MemoryTable ("GameStage"), MessagePackObject (true)]
	public class GameStage {

		[PrimaryKey]
		public int StageID { get; set; }

		public float BallSpeed { get; set; }

		public float BarSpeed { get; set; }

		public BlockPattern BlockPattern { get; set; }

	}
}