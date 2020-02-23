using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum ESoundSEType
	{
		Hoge,
		//--
		MAX
	}

	public static class ExESoundSEType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)ESoundSEType.Hoge, "Sound/SE/DM-CGS-03"),
			}
		);

		public static string ToPath(this ESoundSEType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}