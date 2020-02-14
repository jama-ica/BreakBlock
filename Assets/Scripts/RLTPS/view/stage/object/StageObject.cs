using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Resource;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class StageObject
	{
		protected GameObject _srcObj;
		protected GameObject _gameObj;

		// Constructor
		public StageObject()
		{
			this._srcObj = null;
			this._gameObj = null;
		}

		public GameObject SrcObj { get { return this._srcObj; } }

		public GameObject GameObj { get{ return this._gameObj; } }

		public virtual void SetGameObj(GameObject gameObj)
		{
			this._gameObj = gameObj;
		}

		public abstract void Load(ResourceManager resourceManager);

		public virtual void Start(){}

		public bool IsLoaded()
		{
			return this._srcObj != null;
		}

	}
}