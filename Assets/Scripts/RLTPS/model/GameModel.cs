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
		// Config Data
		// ----------------------------------------------------
		public void SetConfigData(ConfigData configData)
		{
			if(this._configData == null){
				this._configData = configData;
			}
			else{
				this._configData.CopyFrom(configData);
			}
		}

		// ----------------------------------------------------
		// Ball
		// ----------------------------------------------------
		public BallModel CreateBall(/* masterData */)
		{
			if(this._ball == null){
				this._ball = new BallModel(.1f);
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
				this._bar = new BarModel(0.1f);
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
				this._blocks = new BlockModels(10, 3);
			}
			return this._blocks;
		}

		public BlockModel GetBlock(EBlockID id)
		{
			return this._blocks.GetBlock(id);
		}


	}
}
