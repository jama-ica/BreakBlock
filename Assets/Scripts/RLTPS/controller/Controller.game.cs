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

		// onBlockDamaged
		Subject<(EBlockID id, int damage)> _onBlockDamaged;
		public IObservable<(EBlockID id, int damage)> OnBlockDamaged(){
			return this._onBlockDamaged ?? (this._onBlockDamaged = new Subject<(EBlockID id, int damage)>());
		}
		void SendBlockDamaged(EBlockID id, int damage){
			if(this._onBlockDamaged != null){ this._onBlockDamaged.OnNext((id, damage)); }
		}

		// onBlockDead
		Subject<EBlockID> _onBlockDead;
		public IObservable<EBlockID> OnBlockDead(){
			return this._onBlockDead ?? (this._onBlockDead = new Subject<EBlockID>());
		}
		void SendBlockDead(EBlockID id){
			if(this._onBlockDead != null){ this._onBlockDead.OnNext(id); }
		}


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
			SendBlockDamaged(id, damage);
			if(block.IsDead()){
				SendBlockDead(id);
			}
		}

	}
}
