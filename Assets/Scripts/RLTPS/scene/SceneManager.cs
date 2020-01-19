using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.Resource;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneManager
	{
		enum EStep
		{
			WaitingForFinish,
			CreateNewScene,
			UpdateScene,
			//--
			MAX
		}

		readonly Controller controller;
		//--
		Subject<EScene> sbjChangeScene;
		//--
		SceneFactory sceneFactory;
		EStep currentStep;
		BaseScene currentScene;
		EScene nextSceneType;

		
		// Constructor
		public SceneManager(Controller controller, ViewManager viewMng, ResourceManager resourceMng)
		{
			this.controller = controller;
			//--
			this.sbjChangeScene = new Subject<EScene>();
			this.sceneFactory = new SceneFactory(controller, resourceMng, viewMng, sbjChangeScene);
			this.currentStep = EStep.MAX;
			this.currentScene = null;
			this.nextSceneType = EScene.MAX;
			//--
			this.sbjChangeScene.Subscribe(nextSceneType => {
				Debug.Log("subscribe");
				ChangeSceneTo(nextSceneType);
			});
		}

		public void Start()
		{
			ChangeSceneTo(EScene.Init);
		}

		public void Update()
		{
			switch(this.currentStep)
			{
			case EStep.WaitingForFinish:
				if(!this.currentScene.Update()){
					this.currentScene = null;
					this.currentStep = EStep.CreateNewScene;
				}
				break;
			case EStep.CreateNewScene:
				CreateNewScene(this.nextSceneType);
				this.nextSceneType = EScene.MAX;
				this.currentStep = EStep.UpdateScene;
				break;
			case EStep.UpdateScene:
				this.currentScene.Update();
				break;
			default:
				Debug.LogWarning("!step = " + this.currentStep);
				break;
			}

		}

		void ChangeSceneTo(EScene nextSceneType)
		{
			this.nextSceneType = nextSceneType;
			if(this.currentScene is null){
				this.currentStep = EStep.CreateNewScene;
				return;
			}
			StartFrinishCurrentScene();
			this.currentStep = EStep.WaitingForFinish;
		}

		void StartFrinishCurrentScene()
		{
			if(this.currentScene != null){
				this.currentScene.Finish();
			}
		}

		void CreateNewScene(EScene type)
		{
			Assert.IsTrue(this.currentScene is null);
			this.currentScene = this.sceneFactory.CreateScene(type);
		}


		
		
	}
}
