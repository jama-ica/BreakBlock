using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{
	public enum EEffectType
	{
		FireBall,
		//--
		MAX
	}

	public static class ExEEffectType
	{
		static readonly UtilPairs<string> PathPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EEffectType.FireBall, "Prefabs/Effect/FireBall"),
			}
		);

		public static string ToPath(this EEffectType type)
		{
			return PathPairs.GetItem((int)type);
		}
	}
}