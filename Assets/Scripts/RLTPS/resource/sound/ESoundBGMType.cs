using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum ESoundBGMType
	{
		Hoge,
		//--
		MAX
	}

	public static class ExESoundBGMType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)ESoundBGMType.Hoge, "Sound/BGM/Hoge"),
			}
		);

		public static string ToPath(this ESoundBGMType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}