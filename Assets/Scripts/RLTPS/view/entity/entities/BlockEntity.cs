using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
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
		BlockStageObject blockObj;

		// Constructor
		public BlockEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BlockModels blockModel)
			: base()
		{
			this.blockObj = new BlockStageObject(viewManager.Stage, resourceManager.Model);
		}

		public override void Start()
		{
			this.blockObj.Load();
			this.blockObj.Stage();
		}

		public override void End()
		{
			this.blockObj.UnStage();
		}
	}
}