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
	public abstract class EntityBehavior
	{
		public bool Alive { get; protected set; }

		public EntityBehavior(Controller controller, ResourceManager resourceManager, ViewManager viewManager)
		{
			this.Alive = true;
		}

		public abstract void Load(ResourceManager resourceManager);

		public abstract void Start();

		public abstract void Update();
		
		public abstract void End();

		protected void Dead()
		{
			this.Alive = false;
		}

	}
}