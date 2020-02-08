using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.View.Stage;
using RLTPS.Resource;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class EntityObject
	{

		public bool Alive { get; protected set; }

		public EntityObject(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
		{
			this.Alive = false;
		}

		public abstract void Start();

		public abstract void End();
		
	}
}