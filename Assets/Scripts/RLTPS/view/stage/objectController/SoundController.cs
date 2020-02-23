using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.View.Sound;
using RLTPS.Resource;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class SoundController
	{
		readonly SoundPlayer soundPlayer;
		EAudioSourceID audioSourceID;

		// Constructor
		public SoundController(SoundPlayer soundPlayer)
		{
			this.soundPlayer = soundPlayer;
			this.audioSourceID = EAudioSourceID.NONE;
		}

		public void Init(AudioSource audioSource)
		{
			this.audioSourceID = this.soundPlayer.AddAudioSource(audioSource);
		}

		public void PlaySE(ESoundSEType type)
		{
			this.soundPlayer.PlaySE(this.audioSourceID, type);
		}

		public void End()
		{
			this.soundPlayer.RemoveAudioSource(this.audioSourceID);
		}


	}
}