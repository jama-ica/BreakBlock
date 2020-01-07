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
	public class UIResource
	{
		UtilArray<GameObject> gameObjs;

		// Constructor
		public UIResource()
		{
			this.gameObjs = new UtilArray<GameObject>((int)EUIResourceType.MAX);
		}

		public GameObject Load(EUIResourceType type)
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
		
		public GameObject Get(EUIResourceType type)
		{
			return this.gameObjs.Get((int)type);
		}

		public GameObject LoadOrGet(EUIResourceType type)
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

		public void Unload(EUIResourceType type)
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