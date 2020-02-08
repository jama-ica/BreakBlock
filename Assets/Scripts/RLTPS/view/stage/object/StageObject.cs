using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class StageObject
	{
		public GameObject GameObj { get; protected set; }

		// Constructor
		public StageObject()
		{
			this.GameObj = null;
		}

		public void PreLoad()
		{
			Load();
		}

		public abstract GameObject Load();

		public virtual void Start(){}

		public void SetGameObj(GameObject gameObj)
		{
			this.GameObj = gameObj;
		}

	}
}