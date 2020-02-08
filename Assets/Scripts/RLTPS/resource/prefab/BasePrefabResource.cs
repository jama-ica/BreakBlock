using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	/// <summary>
	/// 
	/// </summary>
	public class BasePrefabResource
	{
		protected UtilArray<GameObject> gameObjs;

		// Constructor
		public BasePrefabResource(int size)
		{
			this.gameObjs = new UtilArray<GameObject>(size);
		}

		protected GameObject Load(int key, string path)
		{
			var gameObj = this.gameObjs.Get(key);
			if( gameObj != null ){
				return gameObj;
			}
			gameObj = (GameObject)Resources.Load(path);
			Assert.IsNotNull(gameObj);
			this.gameObjs.Set(key, gameObj);
			return gameObj;
		}
		
		protected GameObject Get(int key)
		{
			return this.gameObjs.Get(key);
		}

		protected GameObject LoadOrGet(int key, string path)
		{
			var gameObj = Get(key);
			if( gameObj != null ){
				return gameObj;
			}
			return Load(key, path);
		}

		protected void Unload(int key)
		{
			GameObject gameObj = this.gameObjs.Get(key);
			if(gameObj is null){
				return;
			}
			Resources.UnloadAsset(gameObj);
			this.gameObjs.Remove(key);
		}
		
	}
}