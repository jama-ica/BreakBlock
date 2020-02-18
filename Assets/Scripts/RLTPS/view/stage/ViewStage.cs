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

		public GameObject Stage(GameObject srcObject, float x, float y, float z)
		{
			Assert.IsNotNull(srcObject);
			return GameObject.Instantiate(srcObject, new Vector3(x, y, z), Quaternion.identity);
		}

		public void UnStage(GameObject gameObj)
		{
			UnityEngine.Object.Destroy(gameObj);
		}

	}
}