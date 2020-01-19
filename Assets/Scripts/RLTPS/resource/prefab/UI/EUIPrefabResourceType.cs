using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EUIPrefabResourceType
	{
		Title,
		//--
		MAX
	}

	public static class ExEUIPrefabResourceType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EUIPrefabResourceType.Title, "Prefabs/UI/TitleCanvas"),
			}
		);

		public static string ToPath(this EUIPrefabResourceType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}