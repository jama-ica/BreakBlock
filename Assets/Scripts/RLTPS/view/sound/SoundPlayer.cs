using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;
using RLTPS.Resource;

namespace RLTPS.View.Sound
{

	/// <summary>
	/// 
	/// </summary>
	public class SoundPlayer
	{
		
		AudioSource bgmAudioSource;
		UtilArray<AudioSource> seAudioSources;
		readonly SoundResource soundResource;

		// Constructor
		public SoundPlayer(SoundResource soundResource)
		{
			this.bgmAudioSource = null;
			this.seAudioSources = new UtilArray<AudioSource>(100);
			this.soundResource = soundResource;
		}

		public EAudioSourceID AddAudioSource(AudioSource audioSource)
		{
			int index = this.seAudioSources.Add(audioSource);
			return (EAudioSourceID)index;
		}

		public void RemoveAudioSource(EAudioSourceID id)
		{
			if(id.IsDisable()){
				return;
			}
			this.seAudioSources.Remove((int)id);
		}

		//----------------------------------------------------
		//	SE
		//----------------------------------------------------
		public void PlaySE(EAudioSourceID audioSourceID, ESoundSEType seType)
		{
			if(audioSourceID.IsDisable()){
				return;
			}
			var audioClip = this.soundResource.Get(seType);
			var audioSource = this.seAudioSources.Get((int)audioSourceID);
			PlaySE(audioSource, audioClip);
		}

		void PlaySE(AudioSource audioSource, AudioClip audioClip)
		{
			Assert.IsNotNull(audioSource);
			Assert.IsNotNull(audioClip);
			audioSource.PlayOneShot(audioClip);
		}

		//----------------------------------------------------
		//	BGM
		//----------------------------------------------------
		public void PlayBGM(ESoundBGMType bgmType)
		{
			var audioClip = this.soundResource.Get(bgmType);
			PlayBGM(audioClip);
		}

		void PlayBGM(AudioClip audioClip)
		{
			Assert.IsNotNull(audioClip);
			this.bgmAudioSource.PlayOneShot(audioClip);
		}
		

	}
}
