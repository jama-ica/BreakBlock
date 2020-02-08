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
		//--
		MAX
	}

	public static class ExEModelPrefabType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EModelPrefabType.Bar, "Prefabs/3D/Bar"),
			}
		);

		public static string ToPath(this EModelPrefabType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}