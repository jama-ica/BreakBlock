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
	public class InitScene : BaseScene
	{
		
		// Constructor
		public InitScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
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
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}
		
		protected override void UpdateScene()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);			
			ChangeSceneTo(EScene.Title);
		}

		protected override bool End()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			return false;
		}

	}
}
