using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Resource
{
	/// <summary>
	/// 
	/// </summary>
	public class ResourceManager
	{
		public ConfigDataResource ConfigData { get; }
		public MasterDataResource MasterData { get; }
		public SaveDataResource SaveData { get; }

		public PrefabResource Prefab { get; }

		public SoundResource Sound { get; }
		
		// Constructor
		public ResourceManager()
		{
			this.ConfigData = new ConfigDataResource();
			this.MasterData = new MasterDataResource();
			this.SaveData = new SaveDataResource();

			this.Prefab = new PrefabResource();

			this.Sound = new SoundResource();
		}

		
		
	}
}