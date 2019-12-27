using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Stage;
using RLTPS.View;

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

		protected readonly IGameData gameData;
		protected readonly Controller controller;
		protected readonly ResourceManager resourceMng;
		protected readonly GameStage stage;
		protected readonly UIManager ui;
		protected readonly SoundPlayer soundPlayer;
		protected readonly EffectPlayer effectPlayer;
		protected readonly GameInputManager gameInputMng;
		//--
		Subject<EScene> sbjChangeScene;
		EStep currentStep;

		// Constructor
		public BaseScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
		{
			this.gameData = gameData;
			this.controller = controller;
			this.resourceMng = resourceMng;
			Assert.IsNotNull(viewMng);
			this.stage = viewMng.Stage;
			this.ui = viewMng.UI;
			this.soundPlayer = viewMng.SoundPlayer;
			this.effectPlayer = viewMng.EffectPlayer;
			this.gameInputMng = viewMng.GameInputMng;

			this.sbjChangeScene = sbjChangeScene;
			this.currentStep = EStep.Init;
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

		protected abstract void UpdateScene();

		protected abstract bool End();

		protected void ChangeSceneTo(EScene type)
		{
			this.sbjChangeScene.OnNext(type);
		}
		
	}
}
