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
		protected GameObject _gameObj;
		//--
		readonly ResourceManager resouceManager;
		readonly ViewStage viewStage;

		// Constructor
		public StageObject(ViewStage viewStage, ResourceManager resouceManager)
		{
			this._gameObj = null;
			//--
			this.resouceManager = resouceManager;
			this.viewStage = viewStage;
		}

		public GameObject GameObj { get{ return this._gameObj; } }

		//----------------------------------------------------
		//	Resource
		//----------------------------------------------------
		protected virtual EPrefabType GetModelPrefabType(){ return EPrefabType.MAX; }

		protected virtual ESoundSEType[] GetSoundSETypes(){ return null; }

		protected virtual ESoundBGMType[] GetSoundBGMTypes(){ return null; }

		public void Load()
		{
			// Model
			this.resouceManager.Prefab.Load( GetModelPrefabType() );

			// SE
			ESoundSEType[] seTypes = GetSoundSETypes();
			if(seTypes != null){
				this.resouceManager.Sound.LoadList( seTypes );
			}
			// BGM
			ESoundBGMType[] bgmTypes = GetSoundBGMTypes();
			if(bgmTypes != null){
				this.resouceManager.Sound.LoadList( bgmTypes );
			}
		}

		public bool IsLoaded()
		{
			//TODO
			return true;
		}

		public virtual void End()
		{
			UnStage();
		}

		//----------------------------------------------------
		//	Stage
		//----------------------------------------------------

		protected GameObject Stage(EPrefabType type, float x, float y, float z)
		{
			var srcGameObj = this.resouceManager.Prefab.Get(type);
			this._gameObj = this.viewStage.Stage(srcGameObj, x, y, z);
			return this._gameObj;
		}

		public bool IsStaged()
		{
			return this._gameObj != null;
		}

		public void UnStage()
		{
			this.viewStage.UnStage(this._gameObj);
			this._gameObj = null;
		}


	}
}