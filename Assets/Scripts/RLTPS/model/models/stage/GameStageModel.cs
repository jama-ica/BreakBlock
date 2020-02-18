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
		BlocksModel _blocks;

		// Constructor
		public GameStageModel()
		{
			this._ball = null;
			this._bar = null;
			this._blocks = null;
		}

		public void Create(MasterData masterData)
		{
			this._ball = new BallModel(masterData.Stage.BallSpeed);
			this._bar = new BarModel(masterData.Stage.BarSpeed);
			this._blocks = new BlocksModel(masterData.Stage.BlockPattern);
		}

		public BallModel Ball{ get{ return this._ball; } }

		public BarModel Bar{ get{ return this._bar; } }

		public BlocksModel Blocks{ get { return this._blocks; } }

		public BlockModel GetBlock(EBlockID id)
		{
			return this._blocks.GetBlock((int)id);
		}
		
	}
}