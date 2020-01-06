using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Unity
{

	/// <summary>
	/// 
	/// </summary>
	public class UnityStage
	{
		
		// Constructor
		public UnityStage()
		{
		}

		public GameObject Stage(GameObject gameObj)
		{
			return GameObject.Instantiate(gameObj, new Vector3(0, 0, 0), Quaternion.identity);
		}

		public void UnStage()
		{
			//TODO
		}
		
	}
}
