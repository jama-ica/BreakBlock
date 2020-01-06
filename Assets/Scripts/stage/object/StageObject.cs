using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class StageObject
	{
		public GameObject GameObj { get; }

		// Constructor
		public StageObject(GameObject GameObj)
		{
			this.GameObj = GameObj;
		}

		public abstract string GetPath();

		
	}
}