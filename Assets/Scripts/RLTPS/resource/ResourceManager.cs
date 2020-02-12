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

		public UIPrefabResource UI { get; }
		public ModelPrefabResource Model { get; }
		
		// Constructor
		public ResourceManager()
		{
			this.ConfigData = new ConfigDataResource();
			this.MasterData = new MasterDataResource();
			this.SaveData = new SaveDataResource();

			this.UI = new UIPrefabResource();
			this.Model = new ModelPrefabResource();
		}

		
		
	}
}