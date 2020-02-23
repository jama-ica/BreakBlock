using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class EffectPlayer
	{
		
		readonly EffectResource effectResource;

		// Constructor
		public EffectPlayer(EffectResource effectResource)
		{
			this.effectResource = effectResource;
		}

		public void Play(EEffectType type, Vector3 pos)
		{
			GameObject srcObj = effectResource.Get(type);
			Assert.IsNotNull(srcObj);
			GameObject gameObj = GameObject.Instantiate(srcObj, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
			UnityEngine.Object.Destroy(gameObj, 1f);
		}
		
	}
}