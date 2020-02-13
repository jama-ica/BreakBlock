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
		readonly ModelPrefabResource resource;

		// Constructor
		public BarStageObject(ModelPrefabResource resource)
			: base()
		{
			this.resource = resource;
		}

		public override GameObject Load()
		{
			return this.resource.Get(EModelPrefabType.Bar);
		}

		public bool IsLoaded()
		{
			return this.GameObj != null;
		}
		
		
	}
}