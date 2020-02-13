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

		BarStageObject barObj;
		//--
		readonly GameStage gameStage;
		readonly GameInput currentInput;

		// Constructor
		public BarEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
			: base(controller, resourceManager, viewManager)
		{
			this.barObj = new BarStageObject();
			//--
			this.gameStage = viewManager.Stage;
			this.currentInput = viewManager.InputManager.CurrentInput;
		}

		// public async override void Start()
		// {
		// 	await this.stageObj.Load();
		// }
		public override void Load(ResourceManager resourceManager)
		{
			this.barObj.Load(resourceManager.Model);
		}

		public override void Start()
		{
			this.gameStage.Stage(barObj);
		}
		
		public override void Update()
		{
			if(!this.barObj.IsLoaded()){
				return;
			}
			if( this.currentInput.IsOn(Model.EGameInput.MoveLeft) ){
				barObj.Move(EDir.LEFT, 1.0f);
				//TODO
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				barObj.Move(EDir.RIGHT, 1.0f);
				//TODO
			}
		}


		public override void End()
		{

		}
		
	}
}