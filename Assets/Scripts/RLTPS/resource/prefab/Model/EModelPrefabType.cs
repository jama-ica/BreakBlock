using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EModelPrefabType
	{
		Bar,
		Ball,
		Block,
		//--
		MAX
	}

	public static class ExEModelPrefabType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EModelPrefabType.Bar, "Prefabs/3D/Bar"),
				((int)EModelPrefabType.Ball, "Prefabs/3D/Ball"),
				((int)EModelPrefabType.Block, "Prefabs/3D/Block"),
			}
		);

		public static string ToPath(this EModelPrefabType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}