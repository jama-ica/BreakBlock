using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.View;
using RLTPS.View.Stage;

namespace RLTPS.Entity
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

		BarStageObject stageObj;


		// Constructor
		public BarEntity(Controller controller, ViewManager viewMng)
			: base(controller, viewMng)
		{
			this.stageObj = null;
		}

		public override void Start()
		{
			this.stageObj = new BarStageObject();
		}
		
		public override void Update()
		{
			if( this.currentInput.IsOn(Model.EGameInput.MoveLeft) ){
				//TODO
			}
			else if( this.currentInput.IsOn(Model.EGameInput.MoveRight) ){
				//TODO
			}
		}

		public override void End()
		{

		}
		
	}
}