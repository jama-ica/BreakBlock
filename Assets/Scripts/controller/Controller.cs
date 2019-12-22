using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Controller
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller
	{
		ModelFacade modelFacade;

		// Constructor
		public Controller(ModelFacade modelFacade)
		{
			this.modelFacade = modelFacade;
		}

		public readonly IGameData GameData { get; }
		
		
	}
}
