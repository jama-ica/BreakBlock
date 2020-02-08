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
		public GameScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager, Subject<EScene> sbjChangeScene)
			: base(controller, resourceManager, viewManager, entityManager, sbjChangeScene)
		{
			this.controller = controller;
			this.resourceManager = resourceManager;
			this.entityManager = entityManager;
			this.inputManager = viewManager.InputManager;
		}

		public override void Init()
		{

		}

		public override void LoadStart()
		{
			resourceManager.Model.Load(EModelPrefabType.Bar);
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public override bool LoadUpdate()
		{
			return false;
		}

		public override void Start()
		{
			this.controller.StartStage();
		}

		public override bool Update()
		{
			this.inputManager.Update();
			this.entityManager.Update();
			return true;
		}

		public override void EndStart()
		{
		}

		public override bool EndUpdate()
		{
			return false;
		}
	}
}
