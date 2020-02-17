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
		//--
		readonly ViewStage stage;

		// Constructor
		public StageObject(ViewStage stage)
		{
			this._srcObj = null;
			this._gameObj = null;
			//--
			this.stage = stage;
		}

		public GameObject SrcObj { get{ return this._srcObj; } }

		public GameObject GameObj { get{ return this._gameObj; } }

		public abstract GameObject Load();

		public bool IsLoaded()
		{
			return this._srcObj != null;
		}

		public void Stage()
		{
			this._gameObj = this.stage.Stage(this._srcObj);
			Staged(this._gameObj);
		}

		protected virtual void Staged(GameObject gameObj){}

		public bool IsStaged()
		{
			return this._gameObj != null;
		}

		public void UnStage()
		{
			this.stage.UnStage(this._gameObj);
			this._gameObj = null;
		}

	}
}