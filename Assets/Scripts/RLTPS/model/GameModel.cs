using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public class GameModel
	{
		BallModel _ball = null;
		BarModel _bar = null;
		BlockModels _blocks = null;
		ConfigData _configData = null;

		// Constructor
		public GameModel()
		{
		}


		// ----------------------------------------------------
		// Ball
		// ----------------------------------------------------
		public BallModel CreateBall(/* masterData */)
		{
			if(this._ball == null){
				this._ball = new BallModel();
			}
			return this._ball;
		}

		public BallModel Ball{ get{ return this._ball; } }


		// ----------------------------------------------------
		// Bar
		// ----------------------------------------------------
		public BarModel CreateBar(/* masterData */)
		{
			if(this._bar == null){
				this._bar = new BarModel();
			}
			return this._bar;
		}

		public BarModel Bar{ get{ return this._bar; } }


		// ----------------------------------------------------
		// Block
		// ----------------------------------------------------

		public BlockModels CreateBlocks(/* masterData */)
		{
			//TODO
			if(this._blocks == null){
				this._blocks = new BlockModels();
			}
			return this._blocks;
		}

		public BlockModel GetBlock(EBlockID id)
		{
			return this._blocks.GetBlock(id);
		}

		// ----------------------------------------------------
		// Config Data
		// ----------------------------------------------------
		public void SetConfigData(ConfigData configData)
		{
			Assert.IsNull(this._configData);
			this._configData = configData;
		}

	}
}
