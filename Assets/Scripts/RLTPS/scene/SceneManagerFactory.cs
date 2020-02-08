using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.View;
using RLTPS.View.Entity;

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

		public static SceneManager Create(Controller controller, ViewManager viewManager, ResourceManager resourceManager, EntityManager entityManager)
		{
			SceneFactory sceneFactory = new SceneFactory(controller, viewManager, resourceManager, entityManager);
			return new SceneManager(sceneFactory);
		}
		
	}
}