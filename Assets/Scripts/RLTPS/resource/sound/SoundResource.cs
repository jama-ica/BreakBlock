using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Resource
{

	/// <summary>
	/// 
	/// </summary>
	public class SoundResource
	{
		protected UtilArray<AudioClip> seAudioClips;
		protected UtilArray<AudioClip> bgmAudioClips;

		// Constructor
		public SoundResource()
		{
			this.seAudioClips = new UtilArray<AudioClip>(100);
			this.bgmAudioClips = new UtilArray<AudioClip>(100);
		}

		
		public AudioClip Load(ESoundSEType type)
		{
			var audioClip = this.seAudioClips.Get((int)type);
			if( audioClip != null ){
				return audioClip;
			}
			audioClip = (AudioClip)Resources.Load(type.ToPath());
			Assert.IsNotNull(audioClip, $"type = {type}, path = {type.ToPath()}");
			this.seAudioClips.Set((int)type, audioClip);
			return audioClip;
		}

		public void LoadList(ESoundSEType[] types)
		{
			Assert.IsNotNull(types);
			for(int i = 0, size = types.Length ; i < size ; i++){
				Load(types[i]);
			}
		}

		public AudioClip Load(ESoundBGMType type)
		{
			var audioClip = this.bgmAudioClips.Get((int)type);
			if( audioClip != null ){
				return audioClip;
			}
			audioClip = (AudioClip)Resources.Load(type.ToPath());
			Assert.IsNotNull(audioClip);
			this.bgmAudioClips.Set((int)type, audioClip);
			return audioClip;
		}

		public void LoadList(ESoundBGMType[] types)
		{
			Assert.IsNotNull(types);
			for(int i = 0, size = types.Length ; i < size ; i++){
				Load(types[i]);
			}
		}

		public AudioClip Get(ESoundSEType type)
		{
			return this.seAudioClips.Get((int)type);
		}

		public AudioClip Get(ESoundBGMType type)
		{
			return this.bgmAudioClips.Get((int)type);
		}


		protected AudioClip LoadOrGet(ESoundSEType type)
		{
			var audioClip = Get(type);
			if( audioClip != null ){
				return audioClip;
			}
			return Load(type);
		}

		protected AudioClip LoadOrGet(ESoundBGMType type)
		{
			var audioClip = Get(type);
			if( audioClip != null ){
				return audioClip;
			}
			return Load(type);
		}


		public void Unload(ESoundSEType type)
		{
			var audioClip = Get(type);
			if(audioClip == null){
				return;
			}
			Resources.UnloadAsset(audioClip);
			this.seAudioClips.Remove((int)type);
		}
				
		public void Unload(ESoundBGMType type)
		{
			var audioClip = Get(type);
			if(audioClip == null){
				return;
			}
			Resources.UnloadAsset(audioClip);
			this.bgmAudioClips.Remove((int)type);
		}

	}
}
