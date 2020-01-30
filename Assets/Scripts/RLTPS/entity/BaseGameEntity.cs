using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.View;
using RLTPS.View.Stage;
using RLTPS.View.Input;
using RLTPS.View.Sound;

namespace RLTPS.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseGameEntity
	{
		protected readonly Controller controller;
		protected readonly GameInput currentInput;
		protected readonly GameStage gameStage;
		protected readonly SoundPlayer soundPlayer;

		public BaseGameEntity(Controller controller, ViewManager viewMng)
		{
			this.controller = controller;
			this.currentInput = viewMng.InputMng.GetCurrentGameInput();
			this.gameStage = viewMng.Stage;
			this.soundPlayer = viewMng.SoundPlayer;
		}

		public abstract void Start();
		
		public abstract void End();

	}
}