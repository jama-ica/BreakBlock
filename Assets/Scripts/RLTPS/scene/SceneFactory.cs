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

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneFactory
	{
		readonly Controller controller;
		readonly ResourceManager resourceMng;
		readonly ViewManager viewMng;
		readonly UniRx.Subject<EScene> sbjChangeScene;

		// Constructor
		public SceneFactory(Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
		{
			this.controller = controller;
			this.resourceMng = resourceMng;
			this.viewMng = viewMng;
			this.sbjChangeScene = sbjChangeScene;
		}

		public BaseScene CreateScene(EScene type)
		{
			switch(type)
			{
			case EScene.Init: return new InitScene(this.controller, this.resourceMng, this.viewMng, this.sbjChangeScene);
			case EScene.Title: return new TitleScene(this.controller, this.resourceMng, this.viewMng, this.sbjChangeScene);
			case EScene.Game: return new GameScene(this.controller, this.resourceMng, this.viewMng, this.sbjChangeScene);
			default:
				break;
			}
			Debug.LogError("!type = " + type);
			return null;
		}

		
		
	}
}
