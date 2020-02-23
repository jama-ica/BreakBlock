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
	public class EffectResource
	{
		protected UtilArray<GameObject> gameObjs;

		// Constructor
		public EffectResource()
		{
			this.gameObjs = new UtilArray<GameObject>(100);
		}

		public GameObject Load(EEffectType type)
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
		
		public void LoadList(EEffectType[] types)
		{
			Assert.IsNotNull(types);
			for(int i = 0, size = types.Length ; i < size ; i++){
				Load(types[i]);
			}
		}

		public GameObject Get(EEffectType type)
		{
			return this.gameObjs.Get((int)type);
		}

		public GameObject LoadOrGet(EEffectType type)
		{
			var gameObj = Get(type);
			if( gameObj != null ){
				return gameObj;
			}
			return Load(type);
		}

		public void Unload(EEffectType type)
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