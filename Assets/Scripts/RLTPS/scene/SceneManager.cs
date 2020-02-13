using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneManager
	{
		enum EStep
		{
			ChangeScene,
			SceneInit,
			SceneLoadStart,
			SceneLoadUpdate,
			SceneStart,
			SceneUpdate,
			SceneEndStart,
			SceneEndUpdate,
			//--
			MAX
		}

		EStep currentStep;
		BaseScene currentScene;
		EScene nextSceneType;
		ScenePool scenePool;

		
		// Constructor
		public SceneManager(SceneFactory sceneFactory)
		{
			this.currentStep = EStep.MAX;
			this.currentScene = null;
			this.nextSceneType = EScene.MAX;
			this.scenePool = CreateScenePool(sceneFactory);
		}

		public void Start()
		{
			this.nextSceneType = EScene.Init;
			this.currentStep = EStep.ChangeScene;
		}

		public void Update(float deltaTime)
		{
			switch(this.currentStep)
			{
			case EStep.ChangeScene:
				this.currentScene = this.scenePool.GetScene(this.nextSceneType);
				this.nextSceneType = EScene.MAX;
				this.currentStep = EStep.SceneInit;
				break;

			case EStep.SceneInit:
				this.currentScene.Init();
				this.currentStep = EStep.SceneLoadStart;
				break;

			case EStep.SceneLoadStart:
				this.currentScene.LoadStart();
				this.currentStep = EStep.SceneLoadUpdate;
				break;
			
			case EStep.SceneLoadUpdate:
				if( !this.currentScene.LoadUpdate(deltaTime) ){
					this.currentStep = EStep.SceneStart;
				}
				break;
			
			case EStep.SceneStart:
				this.currentScene.Start();
				this.currentStep = EStep.SceneUpdate;
				break;
			
			case EStep.SceneUpdate:
				if( !this.currentScene.Update(deltaTime) ){
					this.currentStep = EStep.SceneEndStart;
				}
				break;
			
			case EStep.SceneEndStart:
				this.currentScene.EndStart();
				this.currentStep = EStep.SceneEndUpdate;
				break;
			
			case EStep.SceneEndUpdate:
				if( !this.currentScene.EndUpdate(deltaTime) ){
					Assert.IsTrue(this.nextSceneType != EScene.MAX);
					this.currentStep = EStep.ChangeScene;
				}
				break;

			default:
				Debug.LogWarning("!step = " + this.currentStep);
				break;
			}

		}

		public void FixedUpdate()
		{
			if(this.currentStep != EStep.SceneUpdate){
				return;
			}
			this.currentScene.FixedUpdate();
		}

		ScenePool CreateScenePool(SceneFactory sceneFactory)
		{
			Subject<EScene> sbjChangeScene = new Subject<EScene>();
			IDisposable disposable = sbjChangeScene.Subscribe(nextSceneType => {
				Debug.Log("subscribe");
				ChangeSceneTo(nextSceneType);
			});

			ScenePool scenePool = new ScenePool();
			for(int i = 0, size = (int)EScene.MAX ; i < size ; i++){
				EScene type = (EScene)i;
				BaseScene scene = sceneFactory.CreateScene(type, sbjChangeScene);
				scenePool.SetScene(type, scene);
			}
			return scenePool;
		}

		void ChangeSceneTo(EScene nextSceneType)
		{
			this.nextSceneType = nextSceneType;
			this.currentStep = EStep.ChangeScene;
		}

		
	}
}
