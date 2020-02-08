using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.View;

namespace RLTPS.Scene
{
	/// <summary>
	/// 
	/// </summary>
	public class SceneManagerFactory
	{
		
		// Constructor
		private SceneManagerFactory()
		{
		}

		public static SceneManager Create(Controller controller, ViewManager viewManager, ResourceManager resourceManager)
		{
			SceneFactory sceneFactory = new SceneFactory(controller, viewManager, resourceManager);
			return new SceneManager(sceneFactory);
		}
		
	}
}