using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class ViewStage
	{
		
		// Constructor
		public ViewStage()
		{
		}

		public GameObject Stage(GameObject srcObject)
		{
			return GameObject.Instantiate(srcObject, new Vector3(0, 0, 0), Quaternion.identity);
		}

		public void UnStage(GameObject gameObj)
		{
			UnityEngine.Object.Destroy(gameObj);
		}

	}
}