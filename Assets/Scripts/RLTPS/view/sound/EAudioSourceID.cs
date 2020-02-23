using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Sound
{
	public enum EAudioSourceID
	{
		MIN = 0,
		NONE = int.MaxValue,
	}

	public static class ExEAudioSourceID
	{
		public static bool IsDisable(this EAudioSourceID type)
		{
			return (type == EAudioSourceID.NONE);
		}
	}
}