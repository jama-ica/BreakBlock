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
		public ConfigDataResourceManager ConfigData { get; }
		public MasterDataResourceManager MasterData { get; }
		public SaveDataResourceManager SaveData { get; }

		public UIPrefabResourceManager UI { get; }
		
		// Constructor
		public ResourceManager()
		{
			this.UI = new UIPrefabResourceManager();
		}

		
		
	}
}