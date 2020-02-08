using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Resource
{
	/// <summary>
	/// 
	/// </summary>
	public class ModelPrefabResource : BasePrefabResource
	{

		// Constructor
		public ModelPrefabResource()
			: base((int)EModelPrefabType.MAX)
		{
		}

		public GameObject Load(EModelPrefabType type)
		{
			return Load((int)type, type.ToPath());
		}
		
		public GameObject Get(EModelPrefabType type)
		{
			return Get((int)type);
		}

		public GameObject LoadOrGet(EModelPrefabType type)
		{
			return LoadOrGet((int)type, type.ToPath());
		}

		public void Unload(EModelPrefabType type)
		{
			Unload((int)type);
		}
		
	}
}