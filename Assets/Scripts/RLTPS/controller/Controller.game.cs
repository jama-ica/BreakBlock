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

		Subject<EBlockID> sbjBlockDead = new Subject<EBlockID>();
		public IObservable<EBlockID> OnBlockDead() => this.sbjBlockDead;

		Subject<(EBlockID id, int damage)> sbjBlockDamaged = new Subject<(EBlockID id, int damage)>();
		public IObservable<(EBlockID id, int damage)> OnBlockDamaged() => this.sbjBlockDamaged;

	
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
			int damage = Damage(ref block);
			if(block.IsDead()){
				this.sbjBlockDead.OnNext(id);
			}else{
				this.sbjBlockDamaged.OnNext((id, damage));
			}
		}
		

	}
}
