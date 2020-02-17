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
		public EntityBehavior()
		{
		}

		public abstract void Start();

		public abstract bool Update(float deltaTime);

		public virtual void FixedUpdate(){}
		
		public abstract void End();
		
	}
}