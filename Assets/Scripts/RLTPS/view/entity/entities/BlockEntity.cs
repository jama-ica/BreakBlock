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
	public class BlockEntity : EntityBehavior
	{
		BallStageObject blockObj;
		//--
		readonly GameStage gameStage;

		// Constructor
		public BlockEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
			: base(controller, resourceManager, viewManager)
		{
		}

		public override void Load(ResourceManager resourceManager)
		{
			this.blockObj.Load(resourceManager);
		}

		public override void Start()
		{
			this.gameStage.Stage(blockObj);
		}
		
		public override void Update()
		{
		}

		public override void End()
		{
		}

		
		
	}
}