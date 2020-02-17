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
	public class BlockStageObject : ModelStageObject
	{

		// Constructor
		public BlockStageObject(ViewStage stage, ModelPrefabResource modelPrefabResource)
			: base(stage, modelPrefabResource)
		{
		}

		protected override EModelPrefabType GetPrefabType()
		{
			return EModelPrefabType.Block;
		}

		
	}
}