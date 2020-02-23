using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Control;
using RLTPS.Model;
using RLTPS.View;
using RLTPS.View.Stage;
using RLTPS.View.Input;
using RLTPS.Resource;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public class BlockEntity : EntityObject
	{
		readonly BlockModel blockModel;
		//--
		BlockStageObject blockObj;

		// Constructor
		public BlockEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BlockModel blockModel)
			: base()
		{
			this.blockModel = blockModel;
			//--
			this.blockObj = new BlockStageObject(viewManager.Stage, resourceManager);

			controller.OnBlockDead().Where(id => id == this.blockModel.Id ).Subscribe(id => {
				Dead();
			});

			controller.OnBlockDamaged().Where(data => data.id == this.blockModel.Id ).Subscribe(data => {
				Damaged();
			});
		}

		public override void Start()
		{
			this.blockObj.Load();
			float x = (float)blockModel.X;
			float y = (float)blockModel.Y;
			this.blockObj.Stage(blockModel.Id, x, y, 0.0f);
		}

		public override void End()
		{
			this.blockObj.UnStage();
		}

		void Dead()
		{
			Debug.Log("dead!");
			this._alive = false;
		}

		void Damaged()
		{
			Debug.Log("damaged!");
		}
	}
}