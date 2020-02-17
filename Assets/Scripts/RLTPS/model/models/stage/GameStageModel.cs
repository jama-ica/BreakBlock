using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.LevelData;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class GameStageModel
	{
		BallModel _ball;
		BarModel _bar;
		BlockModels _blocks;

		// Constructor
		public GameStageModel()
		{
			this._ball = new BallModel();
			this._bar = new BarModel();
			this._blocks = new BlockModels();
		}

		public void Init(MasterData masterData)
		{
			this._ball.Init(masterData.Stage.BallSpeed);
			this._bar.Init(masterData.Stage.BarSpeed);
			this._blocks.Init(masterData.Stage.BlockPattern);
		}

		public BallModel Ball{ get{ return this._ball; } }


		public BarModel Bar{ get{ return this._bar; } }


		public BlockModels Blocks{ get { return this._blocks; } }

		public BlockModel GetBlock(EBlockID id){
			return this._blocks.GetBlock(id);
		}
		
	}
}