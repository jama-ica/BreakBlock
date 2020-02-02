using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.Scene;
using RLTPS.View;
using RLTPS.View.Stage;
using RLTPS.Entity;

namespace RLTPS
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : MonoBehaviour
	{
		GameModel model;
		ResourceManager resourceMng;
		ViewManager viewMng;
		Controller controller;
		SceneManager sceneManager;
		GameEntityManager entityMng;
		
		// Constructor
		public Game()
		{
			this.model = new GameModel();
			this.resourceMng = new ResourceManager();
			this.controller = new Controller(this.model, this.resourceMng);
			this.viewMng = new ViewManager(this.controller, this.resourceMng);
			this.sceneManager = new SceneManager(this.controller, this.viewMng, this.resourceMng);
			this.entityMng = new GameEntityManager(this.controller, this.viewMng);
			//
			this.controller.Init(this.entityMng);
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
