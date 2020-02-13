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
	public class BarStageObject : StageObjectMovable
	{

		// Constructor
		public BarStageObject()
			: base()
		{
		}

		public GameObject Load(ModelPrefabResource resource)
		{
			return resource.Get(EModelPrefabType.Bar);
		}

		public bool IsLoaded()
		{
			return this.GameObj != null;
		}
		
		
	}
}