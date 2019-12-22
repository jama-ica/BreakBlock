using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Controller;
using RLTPS.Resource;
using RLTPS.Scene;

namespace RLTPS
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : MonoBehaviour
	{
		SceneManager sceneMng;
		
		// Constructor
		public Game()
		{
			var modelMng = new ModelManager();
			var controller = new Controller(modelManager);
			var viewMng = new ViewManager();
			var entityMng = new EntityManager(controller);
			var resourceMng = new ResourceManager();
			this.sceneMng = new SceneManager();
		}

		protected void Init()
		{
		}

		public void Start()
		{
			Init();

			Cursor.lockState = CursorLockMode.Confined;
			//Cursor.visible = false;
		}

		public void Update()
		{

		}

		public void FixedUpdate()
		{
		}

		public void OnGUI()
		{
		}
		
	}
}
