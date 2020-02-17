using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;
using RLTPS.Model;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class BarStageObject : ModelStageObject
	{

		TransformController transformController;

		// Constructor
		public BarStageObject(ViewStage stage, ModelPrefabResource modelPrefabResource)
			: base(stage, modelPrefabResource)
		{
			this.transformController = null;
		}

		protected override EModelPrefabType GetPrefabType()
		{
			return EModelPrefabType.Bar;
		}

		protected override void Staged(GameObject gameObj)
		{
			this.transformController = new TransformController(gameObj.transform);
		}

		public void Move(EDir dir, float val)
		{
			this.transformController.Move(dir, val);
		}
		
	}
}