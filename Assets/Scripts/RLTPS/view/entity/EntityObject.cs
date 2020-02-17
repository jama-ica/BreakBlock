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

		public bool _alive { get; protected set; }

		public EntityObject()
		{
			this._alive = false;
		}

		public bool Alive { get{ return this._alive; } }

		public abstract void Start();

		public abstract void End();
		
	}
}