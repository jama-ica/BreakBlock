using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseStageObject
	{
		GameObject _gameOjb;
		public GameObject GameObj { get => _gameOjb; }

		// Constructor
		public BaseStageObject(GameObject gameObj)
		{
			this._gameOjb = gameObj;
		}

		public void SetGameObj(GameObject gameObj)
		{
			this._gameOjb = gameObj;
		}

		// Function start will be called when the instance is staged
		public abstract void Start();

		public abstract bool Update();

	}
}