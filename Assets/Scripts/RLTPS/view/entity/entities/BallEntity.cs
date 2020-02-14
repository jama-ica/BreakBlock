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
	public class BallEntity : EntityBehavior
	{
		BallStageObject ballObj;
		//--
		readonly GameStage gameStage;

		// Constructor
		public BallEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
			: base(controller, resourceManager, viewManager)
		{
			this.ballObj = new BallStageObject();
			//--
			this.gameStage = viewManager.Stage;
		}

		
		public override void Load(ResourceManager resourceManager)
		{
			this.ballObj.Load(resourceManager);
		}

		public override void Start()
		{
			this.gameStage.Stage(ballObj);
		}
		
		public override void Update()
		{
		}

		public override void End()
		{
		}
		
	}
}