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
using RLTPS.View.Entity;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneFactory
	{
		readonly Controller controller;
		readonly ViewManager viewManager;
		readonly ResourceManager resourceManager;
		readonly EntityManager entityManager;

		// Constructor
		public SceneFactory(Controller controller, ViewManager viewManager, ResourceManager resourceManager, EntityManager entityManager)
		{
			this.controller = controller;
			this.viewManager = viewManager;
			this.resourceManager = resourceManager;
			this.entityManager = entityManager;
		}

		public BaseScene CreateScene(EScene type, UniRx.Subject<EScene> sbjChangeScene)
		{
			switch(type)
			{
			case EScene.Init: return new InitScene(this.controller, this.resourceManager, this.viewManager, this.entityManager, sbjChangeScene);
			case EScene.Title: return new TitleScene(this.controller, this.resourceManager, this.viewManager, this.entityManager, sbjChangeScene);
			case EScene.Game: return new GameScene(this.controller, this.resourceManager, this.viewManager, this.entityManager, sbjChangeScene);
			default:
				break;
			}
			Debug.LogError("!type = " + type);
			return null;
		}

		
	}
}
