using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EUIPrefab
	{
		Title,
		//--
		MAX
	}

	public static class ExEUIPrefab
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EUIPrefab.Title, "Prefabs/UI/TitleCanvas"),
			}
		);

		public static string ToPath(this EUIPrefab type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}