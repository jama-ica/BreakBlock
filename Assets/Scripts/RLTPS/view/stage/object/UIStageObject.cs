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
	public abstract class UIStageObject : StageObject
	{
		readonly UIPrefabResource uiPrefabResource;
		
		// Constructor
		public UIStageObject(ViewStage stage, UIPrefabResource uiPrefabResource)
			: base(stage)
		{
			this.uiPrefabResource = uiPrefabResource;
		}

		protected abstract EUIPrefabType GetPrefabType();

		public override void Load()
		{
			EUIPrefabType type = GetPrefabType();
			this._srcObj = this.uiPrefabResource.Load(type);
		}


	}
}