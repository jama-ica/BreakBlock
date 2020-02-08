using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.Scene;
using RLTPS.View.Entity;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.Device;
using RLTPS.View.Command;

namespace RLTPS
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : MonoBehaviour
	{
		GameModel model;
		DeviceManager deviceManager;
		ResourceManager resourceManager;
		Controller controller;
		// view
		ViewManager viewManager;
		EntityManager entityManager;
		ViewCommandProcessor viewCommandProcessor;
		// scene
		SceneManager sceneManager;
		
		// Constructor
		public Game()
		{
			this.model = new GameModel();
			this.deviceManager = new DeviceManager();
			this.resourceManager = new ResourceManager();
			this.controller = new Controller(this.model, this.resourceManager);

			this.viewManager = new ViewManager(this.deviceManager);
			this.entityManager = new EntityManager();
			this.viewCommandProcessor = new ViewCommandProcessor(this.controller, this.resourceManager, this.viewManager, this.entityManager);

			SceneFactory sceneFactory = new SceneFactory(controller, viewManager, resourceManager);
			this.sceneManager = new SceneManager(sceneFactory);

			// Init
			this.controller.Init(this.viewCommandProcessor);
		}

		public void Start()
		{

			Cursor.lockState = CursorLockMode.Confined;
			//Cursor.visible = false;

			this.sceneManager.Start();
		}

		public void Update()
		{
			this.sceneManager.Update();
		}

		// public void FixedUpdate()
		// {
		// }

		// public void OnGUI()
		// {
		// }
		
	}
}
