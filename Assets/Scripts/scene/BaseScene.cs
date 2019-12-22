using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseScene
	{
		EntityManager entityMng;
		ResourceManager resourceMng;

		// Constructor
		public BaseScene()
		{
			this.entityMng = null;
			this.assetResourceMng = null;
		}

		public void Init(EntityManager entityMng, ResourceManager resourceMng)
		{
			this.entityMng = entityMng;
			this.resourceMng = resourceMng;
		}

		public abstract void Load();

		public abstract void Start();

		public virtual void Update()
		{
			this.entityMng.Update();
		}

		public abstract void End();
		
	}
}
