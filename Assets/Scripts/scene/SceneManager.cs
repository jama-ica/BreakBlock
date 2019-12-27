using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.Stage;
using RLTPS.View;
using RLTPS.Resource;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneManager
	{
		readonly Controller controller;
		readonly GameStage stage;
		readonly ViewManager viewMng;
		readonly ResourceManager resourceMng;
		
		// Constructor
		public SceneManager(Controller controller, GameStage stage, ViewManager viewMng, ResourceManager resourceMng)
		{
			this.stage = stage;
			this.viewMng = viewMng;
			this.resourceMng = resourceMng;
		}

		public void Start()
		{
			
		}

		public void Update()
		{

		}

		
		
	}
}
