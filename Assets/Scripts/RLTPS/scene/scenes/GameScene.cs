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
using RLTPS.View.Input;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class GameScene : BaseScene
	{
		readonly Controller controller;
		readonly ResourceManager resourceManager;
		readonly EntityManager entityManager;
		readonly InputManager inputManager;

		// Constructor
		public GameScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager)
			: base()
		{
			this.controller = controller;
			this.resourceManager = resourceManager;
			this.entityManager = entityManager;
			this.inputManager = viewManager.InputManager;
		}

		protected override void LoadStart()
		{
			resourceManager.Model.Load(EModelPrefabType.Bar);
		}

		protected override bool LoadUpdate(float deltaTime)
		{
			return false;
		}

		protected override void SceneStart()
		{
			this.controller.StartStage();
		}

		protected override void SceneUpdate(float deltaTime)
		{
			this.inputManager.Update();
			this.entityManager.Update(deltaTime);
		}

		public override void FixedUpdate()
		{
			this.entityManager.FixedUpdate();
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
