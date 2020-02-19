using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.LevelData;
using RLTPS.Model;

namespace RLTPS.Resource
{

	/// <summary>
	/// 
	/// </summary>
	public class MasterDataResource
	{
		
		// Constructor
		public MasterDataResource()
		{
		}

		public RLTPS.Model.MasterData Load()
		{
			var builder = new DatabaseBuilder ();
			builder.Append (new GameStage[] {
				new GameStage { StageID = 0, BallSpeed = 0.1f, BarSpeed = 0.1f, BlockPattern = new BlockPattern {
						Width = 3, Height = 2, Blocks = new BlockData[] {
							new BlockData { X = 0, Y = 4, Hp = 1 },
							new BlockData { X = 3, Y = 4, Hp = 1 },
							new BlockData { X = 6, Y = 4, Hp = 1 },
							new BlockData { X = 0, Y = 6, Hp = 1 },
							new BlockData { X = 3, Y = 6, Hp = 1 },
							new BlockData { X = 6, Y = 6, Hp = 1 },
						}
					}
				},
			});

			byte[] data = builder.Build ();
			var db = new MemoryDatabase (data);

			GameStage stage = db.GameStageTable.FindByStageID(0);
			return new RLTPS.Model.MasterData(stage);
		}


		public bool Save(MasterData masterData)
		{
			//TODO
			return true;
		}

	}
}
