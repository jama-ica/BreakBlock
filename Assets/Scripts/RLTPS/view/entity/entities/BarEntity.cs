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
		readonly Controller controller;
		readonly GameInput currentInput;

		// Constructor
		public BarEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BarModel barModel)
			: base()
		{
			this.step = EStep.MAX;
			this.barObj = new BarStageObject(viewManager.Stage, resourceManager.Model);
			//--
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
				goto case EStep.LoadUpdate;

			case EStep.LoadUpdate:
				if(this.barObj.IsLoaded()){
					this.barObj.Stage();
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
				this.barObj.Move(EDir.LEFT, 1.0f);
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				this.barObj.Move(EDir.RIGHT, 1.0f);
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