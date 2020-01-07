using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EUIResourceType
	{
		Title,
		//--
		MAX
	}

	public static class ExEUIResourceType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EUIResourceType.Title, "Prefabs/UI/TitleCanvas"),
			}
		);

		public static string ToPath(this EUIResourceType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}