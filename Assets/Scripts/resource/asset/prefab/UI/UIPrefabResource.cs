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
	public class UIPrefabResource
	{
		UtilArray<GameObject> gameObjs;

		// Constructor
		public UIPrefabResource()
		{
			this.gameObjs = new UtilArray<GameObject>((int)EUIPrefab.MAX);
		}

		public GameObject Load(EUIPrefab type)
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
		
		public GameObject Get(EUIPrefab type)
		{
			return this.gameObjs.Get((int)type);
		}

		public GameObject LoadOrGet(EUIPrefab type)
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

		public void Unload(EUIPrefab type)
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