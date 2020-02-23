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
	public class TitleUIStageObject : StageObject
	{
		
		// Constructor
		public TitleUIStageObject(ViewStage stage, ResourceManager resouceManager)
			: base(stage, resouceManager)
		{
		}

		protected override EPrefabType GetModelPrefabType(){ return EPrefabType.UI_Title; }


	}
}