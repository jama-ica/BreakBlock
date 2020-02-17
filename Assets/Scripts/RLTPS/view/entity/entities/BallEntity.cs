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
		enum EStep
		{
			LoadStart,
			LoadUpdate,
			EntityUpdate,
			//--
			MAX
		}

		EStep step;
		BallStageObject ballObj;

		// Constructor
		public BallEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BallModel ballModel)
			: base()
		{
			this.step = EStep.MAX;
			this.ballObj = new BallStageObject(viewManager.Stage, resourceManager.Model);
		}

		public override void Start()
		{
			this.step = EStep.LoadStart;
		}
		
		public override bool Update(float deltaTime)
		{
			switch(this.step)
			{
			case EStep.LoadStart:
				this.ballObj.Load();
				goto case EStep.LoadUpdate;

			case EStep.LoadUpdate:
				if(this.ballObj.IsLoaded()){
					this.ballObj.Stage();
					goto case EStep.EntityUpdate;
				}
				break;

			case EStep.EntityUpdate:
				EntityUpdate(deltaTime);
				break;

			default:
				Debug.LogWarning("!step = " + this.step);
				break;
			}

			return true;
		}

		void EntityUpdate(float deltaTime)
		{
		}

		// public override void FixedUpdate()
		// {

		// }
				
		public override void End()
		{
			this.ballObj.UnStage();
		}
	}
}