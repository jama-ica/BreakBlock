using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Scene
{
	public enum EScene
	{
		Init,
		Title,
		Game,
		//--
		MAX
	}

	public static class ExEScene
	{
		static readonly UtilPairs<string> TextPairs = new UtilPairs<string>(
			new (int key, string val)[]{
				((int)EScene.Init, "Init"),
				((int)EScene.Title, "Title"),
				((int)EScene.Game, "Game"),
			}
		);

		public static string ToText(this EScene type)
		{
			return TextPairs.GetItem((int)type);
		}
	}
}