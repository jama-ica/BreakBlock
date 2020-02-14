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

		public override void Load(ResourceManager resourceManager)
		{
			this._srcObj = resourceManager.Model.LoadOrGet(EModelPrefabType.Bar);
		}

		
	}
}