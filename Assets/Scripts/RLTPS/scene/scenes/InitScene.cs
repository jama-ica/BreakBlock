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
		public InitScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager)
			: base()
		{
			this.controller = controller;
		}

		protected override void LoadStart()
		{
			this.controller.InitLoad();
		}

		protected override bool LoadUpdate(float deltaTime)
		{
			return false;
		}
		
		protected override void SceneStart()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		protected override void SceneUpdate(float deltaTime)
		{
			ChangeSceneTo(EScene.Title);
		}

		public override void FixedUpdate()
		{
		}

		protected override void EndStart()
		{
		}

		protected override bool EndUpdate(float deltaTime)
		{
			return false;
		}

	}
}
