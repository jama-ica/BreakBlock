using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Model;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller // for Game
	{
	
		public void StartStage()
		{
			this.gameModel.CreateStage();
			this.viewCommandSender.CreateBar(this.gameModel.Stage.Bar);
			this.viewCommandSender.CreateBall(this.gameModel.Stage.Ball);
			this.viewCommandSender.CreateBlocks(this.gameModel.Stage.Blocks);
		}

		public void BallHitWith(EBlockID id)
		{
			BlockModel block = this.gameModel.Stage.GetBlock(id);
			Damage(ref block);
			if(block.IsDead()){
				//TODO
			}
		}
		

	}
}
