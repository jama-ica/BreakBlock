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
	public abstract class ModelStageObject : StageObject
	{
		
		readonly ModelPrefabResource modelPrefabResource;


		// Constructor
		public ModelStageObject(ViewStage stage, ModelPrefabResource modelPrefabResource)
			: base(stage)
		{
			this.modelPrefabResource = modelPrefabResource;
		}

		protected abstract EModelPrefabType GetPrefabType();

		public override void Load()
		{
			EModelPrefabType type = GetPrefabType();
			this._srcObj = this.modelPrefabResource.Load(type);
		}


	}
}