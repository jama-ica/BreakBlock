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
	public class GameScene : BaseScene
	{
		
		// Constructor
		public GameScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
			: base(gameData, controller, resourceMng, viewMng, sbjChangeScene)
		{
		}

		protected override bool Load()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			return false;
		}

		protected override void Start()
		{
			this.controller.StartStage();
		}
		
		protected override void UpdateScene()
		{
			this.gameStage.Update();
		}

		protected override bool End()
		{
			return false;
		}
		
	}
}
