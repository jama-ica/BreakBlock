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
	public class BallStageObject : StageObject
	{
		
		// Constructor
		public BallStageObject()
			: base()
		{
		}

		public override void Load(ResourceManager resourceManager)
		{
			this._srcObj = resourceManager.Model.LoadOrGet(EModelPrefabType.Ball);
		}
		
		
	}
}