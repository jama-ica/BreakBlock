using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.Scene;
using RLTPS.Stage;
using RLTPS.View;

namespace RLTPS
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : MonoBehaviour
	{
		ModelFacade modelMng;
		Controller controller;
		ViewManager viewMng;
		GameStage stage;
		ResourceManager resourceMng;
		SceneManager sceneMng;
		
		// Constructor
		public Game()
		{
			this.resourceMng = new ResourceManager();
			this.modelMng = new ModelFacade();
			this.controller = new Controller(modelMng);
			this.viewMng = new ViewManager(modelMng.GameData, this.controller, this.resourceMng);
			this.sceneMng = new SceneManager(this.controller, this.stage, this.viewMng, this.resourceMng);
		}

		public void Start()
		{

			Cursor.lockState = CursorLockMode.Confined;
			//Cursor.visible = false;

			this.sceneMng.Start();
		}

		public void Update()
		{
			this.sceneMng.Update();
		}

		public void FixedUpdate()
		{
		}

		public void OnGUI()
		{
		}
		
	}
}
