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
	public class UIPrefabResource : BasePrefabResource
	{

		// Constructor
		public UIPrefabResource()
			: base((int)EUIPrefabType.MAX)
		{
		}

		public GameObject Load(EUIPrefabType type)
		{
			return Load((int)type, type.ToPath());
		}
		
		public GameObject Get(EUIPrefabType type)
		{
			return Get((int)type);
		}

		public GameObject LoadOrGet(EUIPrefabType type)
		{
			return LoadOrGet((int)type, type.ToPath());
		}

		public void Unload(EUIPrefabType type)
		{
			Unload((int)type);
		}
		
	}
}