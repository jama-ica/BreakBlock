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
		ResourceManager resourceMng;
		ModelFacade modelMng;
		Controller controller;
		ViewManager viewMng;
		GameStage stage;
		SceneManager sceneMng;
		
		// Constructor
		public Game()
		{
			this.resourceMng = new ResourceManager();
			this.modelMng = new ModelFacade();
			this.controller = new Controller(this.modelMng);
			this.viewMng = new ViewManager(this.modelMng.GameData, this.controller, this.resourceMng);
			this.stage = new GameStage();
			this.sceneMng = new SceneManager(this.modelMng.GameData, this.controller, this.stage, this.viewMng, this.resourceMng);
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
