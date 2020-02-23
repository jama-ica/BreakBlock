using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Sound
{
	/// <summary>
	/// 
	/// </summary>
	public class SoundSource
	{
		AudioSource _audioSource;

		// Constructor
		public SoundSource(AudioSource audioSource)
		{
			this._audioSource = audioSource;
		}

		AudioSource AudioSource{ get { return this._audioSource; } }

		
	}
}