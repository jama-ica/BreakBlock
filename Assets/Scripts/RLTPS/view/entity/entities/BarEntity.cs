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
	public class BarEntity : BaseUpdatableGameEntity
	{
		public static BarEntity CreateBarEntity(Controller controller, ViewManager viewMng)
		{
			return new BarEntity(controller, viewMng);
		}


		// Constructor
		public BarEntity(Controller controller, ViewManager viewMng)
			: base(controller, viewMng)
		{
		}

		public override void Start()
		{

		}

		
		public override void Update()
		{

		}


		public override void End()
		{

		}
		
	}
}