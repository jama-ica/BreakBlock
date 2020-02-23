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
	public class BarStageObject : StageObject
	{

		TransformController transformController;

		// Constructor
		public BarStageObject(ViewStage stage, ResourceManager resouceManager)
			: base(stage, resouceManager)
		{
			this.transformController = null;
		}

		//----------------------------------------------------
		//	Resource
		//----------------------------------------------------
		protected override EPrefabType GetModelPrefabType(){ return EPrefabType.Bar; }

		public override void End()
		{
			base.End();
		}

		//----------------------------------------------------
		//	Stage
		//----------------------------------------------------
		public void Stage(float x, float y, float z)
		{
			var gameObj = Stage(GetModelPrefabType(), x, y, z);
			OnStaged(gameObj);
		}

		void OnStaged(GameObject gameObj)
		{
			this.transformController = new TransformController(gameObj.transform);
		}

		//----------------------------------------------------
		//	Control
		//----------------------------------------------------
		public void Move(EDir dir, float val)
		{
			this.transformController.Move(dir, val);
		}
		
	}
}