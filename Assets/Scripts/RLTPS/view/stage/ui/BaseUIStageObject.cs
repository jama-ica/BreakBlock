using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseUIStageObject : BaseStageObject
	{
		
		// Constructor
		public BaseUIStageObject(GameObject gameObj)
			: base(gameObj)
		{
		}

	}
}