using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using UniRx.Triggers;
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
		Vector3 vector;
		//--
		readonly BallModel ballModel;
		readonly Controller controller;

		// Constructor
		public BallEntity(Controller controller, ResourceManager resourceManager, ViewManager viewManager, BallModel ballModel)
			: base()
		{
			this.step = EStep.MAX;
			this.ballObj = new BallStageObject(viewManager.Stage, resourceManager, viewManager.SoundPlayer);
			this.vector = new Vector3();
			//--
			this.ballModel = ballModel;
			this.controller = controller;
		}

		public override void Start()
		{
			this.step = EStep.LoadStart;
			this.vector = new Vector3(0.3f, 0.3f, 0.0f);
		}
		
		public override bool Update(float deltaTime)
		{
			switch(this.step)
			{
			case EStep.LoadStart:
				this.ballObj.Load();
				this.step = EStep.LoadUpdate;
				goto case EStep.LoadUpdate;

			case EStep.LoadUpdate:
				if(this.ballObj.IsLoaded()){
					Stage(this.ballObj);
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


		void Stage(BallStageObject ballObj)
		{
			ballObj.Stage(1.0f, 1.0f, 0.0f);
			ballObj.Trigger.OnCollisionEnterAsObservable().Subscribe(collision => {
				Debug.Log("hit!");
				ballObj.PlaySE(ESoundSEType.Hoge);
				if(collision.collider.tag == BlockStageObject.Tag){
					EBlockID id = BlockStageObject.ConvertToID(collision.collider.gameObject.name);
					this.controller.BallHitWith(id);
				}
				for(int i = 0, size = collision.contacts.Length ; i < size ; i++)
				{
					this.vector = Vector3.Reflect(this.vector, collision.contacts[i].normal);
				}
			});
		}

		// void OnStaged(BallStageObject ballObj)
		// {
		// 	trigger = ballObj.GameObj.AddComponent<ObservableTriggerTrigger>();
		// 	trigger.OnTriggerEnterAsObservable().Subscribe(collider => {
		// 		Debug.Log("hit!");
		// 		if(collider.tag == "Block"){
		// 			var name = collider.gameObject.name;
		// 			//TODO EBlockID id = name.ToID();
		// 			//this.controller.BallHitWith(id);
		// 		}
		// 	});
		// }

		void EntityUpdate(float deltaTime)
		{
			this.ballObj.Move(this.vector * this.ballModel.Speed);
		}

		// public override void FixedUpdate()
		// {
		// 	if(this.step != EStep.EntityUpdate){
		// 		return;
		// 	}
		// 	this.ballObj.Move(this.vector * this.ballModel.Speed);
		// }
				
		public override void End()
		{
			this.ballObj.UnStage();
		}
	}
}