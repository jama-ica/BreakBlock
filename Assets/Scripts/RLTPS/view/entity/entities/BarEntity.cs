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
	public class BarEntity : EntityBehavior
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
		BarStageObject barObj;
		//--
		readonly BarModel barModel;
		readonly Controller controller;
		readonly GameInput currentInput;

		// Constructor
		public BarEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BarModel barModel)
			: base()
		{
			this.step = EStep.MAX;
			this.barObj = new BarStageObject(viewManager.Stage, resourceManager);
			//--
			this.barModel = barModel;
			this.controller = controller;
			this.currentInput = viewManager.InputManager.CurrentInput;
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
				this.barObj.Load();
				this.step = EStep.LoadUpdate;
				goto case EStep.LoadUpdate;

			case EStep.LoadUpdate:
				if(this.barObj.IsLoaded()){
					this.barObj.Stage(0.0f, 0.0f, 0.0f);
					this.step = EStep.EntityUpdate;
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
			if( this.currentInput.IsOn(Model.EGameInput.MoveLeft) ){
				this.barObj.Move(EDir.LEFT, this.barModel.Speed);
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				this.barObj.Move(EDir.RIGHT, this.barModel.Speed);
			}
		}

		// public override void FixedUpdate()
		// {

		// }
				
		public override void End()
		{
			this.barObj.UnStage();
		}
	}
}