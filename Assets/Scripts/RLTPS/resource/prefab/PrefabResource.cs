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
	public class PrefabResource
	{
		protected UtilArray<GameObject> gameObjs;

		// Constructor
		public PrefabResource()
		{
			this.gameObjs = new UtilArray<GameObject>(100);
		}

		public GameObject Load(EPrefabType type)
		{
			var gameObj = this.gameObjs.Get((int)type);
			if( gameObj != null ){
				return gameObj;
			}
			gameObj = (GameObject)Resources.Load(type.ToPath());
			Assert.IsNotNull(gameObj, $"!type = {type}, path = {type.ToPath()}");
			this.gameObjs.Set((int)type, gameObj);
			return gameObj;
		}
		
		public GameObject Get(EPrefabType type)
		{
			return this.gameObjs.Get((int)type);
		}

		public GameObject LoadOrGet(EPrefabType type)
		{
			var gameObj = Get(type);
			if( gameObj != null ){
				return gameObj;
			}
			return Load(type);
		}

		public void Unload(EPrefabType type)
		{
			GameObject gameObj = Get(type);
			if(gameObj is null){
				return;
			}
			Resources.UnloadAsset(gameObj);
			this.gameObjs.Remove((int)type);
		}
		
	}
}