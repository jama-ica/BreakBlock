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
	public class BlockStageObject : ModelStageObject
	{
		public static readonly string Tag = "Block";

		public static string GetName(EBlockID id)
		{
			var sb = new StringBuilder(BlockStageObject.Tag);
			sb.Append(((int)id).ToString());
			return sb.ToString();
		}

		public static EBlockID ConvertToID(string name)
		{
			return (EBlockID)int.Parse(name.Substring(Tag.Length));
		}

		// Constructor
		public BlockStageObject(ViewStage stage, ModelPrefabResource modelPrefabResource)
			: base(stage, modelPrefabResource)
		{
		}

		protected override EModelPrefabType GetPrefabType()
		{
			return EModelPrefabType.Block;
		}

		public void Stage(EBlockID id, float x, float y, float z)
		{
			Stage(x, y, z);
			this._gameObj.name = BlockStageObject.GetName(id);
		}
		
	}
}