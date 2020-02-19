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
	public class BallStageObject : ModelStageObject
	{

		TransformController transformController;
		//RigidbodyController rigidbodyController;

		// Constructor
		public BallStageObject(ViewStage stage, ModelPrefabResource modelPrefabResource)
			: base(stage, modelPrefabResource)
		{
			this.transformController = null;
		}

		protected override EModelPrefabType GetPrefabType()
		{
			return EModelPrefabType.Ball;
		}

		protected override void OnStaged(GameObject gameObj)
		{
			this.transformController = new TransformController(gameObj.transform);
		}
		
		public void Move(Vector3 vec)
		{
			this.transformController.Move(vec);
		}

	}
}