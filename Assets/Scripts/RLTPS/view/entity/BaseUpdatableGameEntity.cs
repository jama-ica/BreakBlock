using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.View.Stage;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseUpdatableGameEntity : BaseGameEntity
	{
		public BaseUpdatableGameEntity(Controller controller, ViewManager viewMng)
			: base(controller, viewMng)
		{

		}

		public abstract void Update();

		
	}
}