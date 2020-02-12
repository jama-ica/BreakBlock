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
			CreateBar();
			CreateBall();
			CreateBlocks();
		}

		public void BallHitWith(EBlockID id)
		{
			BlockModel block = this.gameModel.GetBlock(id);
			Damage(ref block);
			if(block.IsDead()){
				//TODO
			}
		}
		

	}
}
