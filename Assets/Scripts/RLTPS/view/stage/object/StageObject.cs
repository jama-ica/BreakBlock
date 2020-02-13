using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class StageObject
	{
		protected GameObject _gameObj;

		// Constructor
		public StageObject()
		{
			this._gameObj = null;
		}

		public GameObject GameObj { get{ return this._gameObj; } }

		public virtual void SetGameObj(GameObject gameObj)
		{
			this._gameObj = gameObj;
		}

		public virtual void Start(){}

	}
}