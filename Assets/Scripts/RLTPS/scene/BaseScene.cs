using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.Entity;
using RLTPS.View.Input;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseScene
	{
		enum EStep
		{
			Init,
			Load,
			Start,
			Update,
			End,
			//--
			MAX,
		}

		protected readonly Controller controller;
		protected readonly InputManager InputMng;

		protected readonly ResourceManager resourceMng;
		protected readonly Subject<EScene> sbjChangeScene;
		//--
		EStep currentStep;
		GameEntityManager GameEntityMng;

		// Constructor
		public BaseScene(Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
		{
			this.controller = controller;
			this.InputMng = viewMng.InputMng;
			this.resourceMng = resourceMng;
			this.sbjChangeScene = sbjChangeScene;
			//
			this.currentStep = EStep.Init;
			this.GameEntityMng = new GameEntityManager(controller, viewMng);
		}

		public bool Update()
		{
			switch(this.currentStep)
			{
			case EStep.Init:
				this.currentStep = EStep.Load;
				break;
			case EStep.Load:
				if( !Load() ){
					this.currentStep = EStep.Start;
				}
				break;
			case EStep.Start:
				Start();
				this.currentStep = EStep.Update;
				break;
			case EStep.Update:
				UpdateScene();
				break;
			case EStep.End:
				return End();
			default:
				Debug.LogWarning("!currentStep = " + this.currentStep);
				break;
			}
			return true;
		}

		public void Finish()
		{
			this.currentStep = EStep.End;
		}

		protected abstract bool Load();

		protected abstract void Start();

		protected void UpdateScene()
		{
			this.InputMng.Update();
			this.GameEntityMng.Update();
		}

		protected abstract bool End();

		protected void ChangeSceneTo(EScene type)
		{
			this.sbjChangeScene.OnNext(type);
		}
		
	}
}
