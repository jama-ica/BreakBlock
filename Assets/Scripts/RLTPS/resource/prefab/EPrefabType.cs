using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EPrefabType
	{
		Bar,
		Ball,
		Block,
		UI_Title,
		//--
		MAX
	}

	public static class ExEPrefabType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EPrefabType.Bar, "Prefabs/3D/Bar"),
				((int)EPrefabType.Ball, "Prefabs/3D/Ball"),
				((int)EPrefabType.Block, "Prefabs/3D/Block"),
				((int)EPrefabType.UI_Title, "Prefabs/UI/TitleCanvas"),
			}
		);

		public static string ToPath(this EPrefabType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}