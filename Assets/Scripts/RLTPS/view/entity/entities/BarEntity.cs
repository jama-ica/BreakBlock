using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
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

		BarStageObject barObj;
		GameInput currentInput;

		// Constructor
		public BarEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
			: base(controller, resourceManager, viewManager)
		{
			this.barObj = new BarStageObject(resourceManager.Model);
			this.currentInput = viewManager.InputManager.CurrentInput;
		}

		// public async override void Start()
		// {
		// 	await this.stageObj.Load();
		// }
		public override void Start()
		{
			this.barObj.Load();
		}
		
		public override void Update()
		{
			if(!this.barObj.IsLoaded()){
				return;
			}
			if( this.currentInput.IsOn(Model.EGameInput.MoveLeft) ){
				//TODO
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				//TODO
			}
		}


		public override void End()
		{

		}
		
	}
}