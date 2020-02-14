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
		RigidBodyController rigidBodyController;
		TransFormController transFormController;
		//--
		readonly GameStage gameStage;
		readonly GameInput currentInput;

		// Constructor
		public BarEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
			: base(controller, resourceManager, viewManager)
		{
			this.barObj = new BarStageObject();
			this.rigidBodyController = null;
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
			this.barObj.Load(resourceManager);
		}

		public override void Start()
		{
			this.gameStage.Stage(barObj, .0f, .0f, .0f);
			this.rigidBodyController = new RigidBodyController(barObj.GameObj.GetComponent<Rigidbody>());
			this.transFormController = new TransFormController(barObj.GameObj.transform);
		}
		
		public override void Update()
		{
			if(!this.barObj.IsLoaded()){
				return;
			}
			if( this.currentInput.IsOn(Model.EGameInput.MoveLeft) ){
				this.transFormController.Move(EDir.LEFT, .1f);
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				this.transFormController.Move(EDir.RIGHT, .1f);
			}
		}

		public override void End()
		{

		}
		
	}
}