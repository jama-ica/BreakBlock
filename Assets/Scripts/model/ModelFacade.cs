using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{

	/// <summary>
	/// 
	/// </summary>
	public partial class ModelFacade
	{
		public GameData GameData { get; }

		RLTPS.Model.ConfigDataManager settingDataManager;
		
		// Constructor
		public ModelFacade()
		{
			this.settingDataManager = new ConfigDataManager();
		}

		
		
	}
}
