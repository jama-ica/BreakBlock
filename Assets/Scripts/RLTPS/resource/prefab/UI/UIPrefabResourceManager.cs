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
	public class UIPrefabResourceManager
	{
		UtilArray<GameObject> gameObjs;

		// Constructor
		public UIPrefabResourceManager()
		{
			this.gameObjs = new UtilArray<GameObject>((int)EUIPrefabResourceType.MAX);
		}

		public GameObject Load(EUIPrefabResourceType type)
		{
			var gameObj = this.gameObjs.Get((int)type);
			if( gameObj != null ){
				return gameObj;
			}
			gameObj = (GameObject)Resources.Load(type.ToPath());
			Assert.IsNotNull(gameObj);
			this.gameObjs.Set((int)type, gameObj);
			return gameObj;
		}
		
		public GameObject Get(EUIPrefabResourceType type)
		{
			return this.gameObjs.Get((int)type);
		}

		public GameObject LoadOrGet(EUIPrefabResourceType type)
		{
			var gameObj = this.gameObjs.Get((int)type);
			if( gameObj != null ){
				return gameObj;
			}
			gameObj = (GameObject)Resources.Load(type.ToPath());
			Assert.IsNotNull(gameObj);
			this.gameObjs.Set((int)type, gameObj);
			return gameObj;
		}

		public void Unload(EUIPrefabResourceType type)
		{
			GameObject gameObj = this.gameObjs.Get((int)type);
			if(gameObj is null){
				return;
			}
			Resources.UnloadAsset(gameObj);
			this.gameObjs.Remove((int)type);
		}
		
	}
}