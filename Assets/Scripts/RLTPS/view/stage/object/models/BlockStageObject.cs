using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;
using RLTPS.Model;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class BlockStageObject : StageObject
	{
		public static readonly string Tag = "Block";

		public static string ConvertToName(EBlockID id)
		{
			var sb = new StringBuilder(Tag, 16);
			sb.Append(((int)id).ToString());
			return sb.ToString();
		}

		public static EBlockID ConvertToID(string name)
		{
			return (EBlockID)int.Parse(name.Substring(Tag.Length));
		}

		// Constructor
		public BlockStageObject(ViewStage stage, ResourceManager resouceManager)
			: base(stage, resouceManager)
		{
		}

		//----------------------------------------------------
		//	Resource
		//----------------------------------------------------
		protected override EPrefabType GetModelPrefabType(){ return EPrefabType.Block; }

		//----------------------------------------------------
		//	Stage
		//----------------------------------------------------
		public void Stage(EBlockID id, float x, float y, float z)
		{
			var gameObj = Stage(GetModelPrefabType(), x, y, z);
			this._gameObj.name = BlockStageObject.ConvertToName(id);
		}
		
	}
}