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

		BaseScene currentScene;
		ScenePool scenePool;

		// Constructor
		public SceneManager(SceneFactory sceneFactory)
		{
			this.currentScene = null;
			this.scenePool = CreateScenePool(sceneFactory);
		}

		public void Start()
		{
			this.currentScene = this.scenePool.GetScene(EScene.Init);
			this.currentScene.Init();
		}

		public void Update(float deltaTime)
		{
			if(!this.currentScene.Update(deltaTime)){
				EScene nextSceneType = this.currentScene.NextSceneType;
				Assert.IsTrue(nextSceneType != EScene.MAX);
				this.currentScene = this.scenePool.GetScene(nextSceneType);
				this.currentScene.Init();
			}
		}

		public void FixedUpdate()
		{
			if(this.currentScene == null){
				return;
			}
			this.currentScene.FixedUpdate();
		}

		ScenePool CreateScenePool(SceneFactory sceneFactory)
		{
			ScenePool scenePool = new ScenePool();
			for(int i = 0, size = (int)EScene.MAX ; i < size ; i++){
				EScene type = (EScene)i;
				BaseScene scene = sceneFactory.CreateScene(type);
				scenePool.SetScene(type, scene);
			}
			return scenePool;
		}

	}
}
