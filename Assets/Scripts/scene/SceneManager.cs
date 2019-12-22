using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class SceneManager
	{
		readonly EntityManager entityMng;
		readonly ViewManager viewMng;
		readonly ResourceManager resourceMng;
		
		// Constructor
		public SceneManager(ResourceManager resourceMng)
		{
			this.resourceMng = resourceMng;
		}

		
		
	}
}
