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
	public class InitScene : BaseScene
	{
		
		readonly Controller controller;

		// Constructor
		public InitScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager, Subject<EScene> sbjChangeScene)
			: base(controller, resourceManager, viewManager, entityManager, sbjChangeScene)
		{
			this.controller = controller;
		}

		public override void Init()
		{

		}

		public override void LoadStart()
		{
			this.controller.InitLoad();
		}

		public override bool LoadUpdate(float deltaTime)
		{
			return false;
		}
		
		public override void Start()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public override bool Update(float deltaTime)
		{
			ChangeSceneTo(EScene.Title);
			return false;
		}

		public override void EndStart()
		{
		}

		public override bool EndUpdate(float deltaTime)
		{
			return false;
		}

	}
}
