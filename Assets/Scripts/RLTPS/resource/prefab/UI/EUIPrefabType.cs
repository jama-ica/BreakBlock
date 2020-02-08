using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EUIPrefabType
	{
		Title,
		//--
		MAX
	}

	public static class ExEUIPrefabType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EUIPrefabType.Title, "Prefabs/UI/TitleCanvas"),
			}
		);

		public static string ToPath(this EUIPrefabType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}