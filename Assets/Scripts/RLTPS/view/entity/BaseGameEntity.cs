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
	public abstract class BaseGameEntity
	{
		protected readonly Controller controller;
		protected readonly GameInput gameInput;
		protected readonly GameStage gameStage;
		protected readonly SoundPlayer soundPlayer;

		public BaseGameEntity(Controller controller, ViewManager viewMng)
		{
			this.controller = controller;
			this.gameInput = viewMng.GameInputMng.getCurrentGameInput();
			this.gameStage = viewMng.Stage;
			this.soundPlayer = viewMng.SoundPlayer;
		}

		public abstract void Start();
		
		public abstract void End();

	}
}