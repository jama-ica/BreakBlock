using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Scene
{
	/// <summary>
	/// 
	/// </summary>
	public class ScenePool
	{
		Dictionary<int, BaseScene> sceneMap;
		 
		// Constructor
		public ScenePool()
		{
			this.sceneMap = new Dictionary<int, BaseScene>();
		}

		public void SetScene(EScene type, BaseScene scene)
		{
			this.sceneMap.Add((int)type, scene);
		}

		public BaseScene GetScene(EScene type)
		{
			Assert.IsTrue(this.sceneMap.ContainsKey((int)type));
			return this.sceneMap[(int)type];
		}
		
	}
}