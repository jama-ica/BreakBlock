using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Stage;
using RLTPS.View;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseScene
	{
		protected readonly IGameData gameData;
		protected readonly Controller controller;
		protected readonly ResourceManager resourceMng;
		protected readonly GameStage stage;
		protected readonly UIManager ui;
		protected readonly SoundPlayer soundPlayer;
		protected readonly EffectPlayer effectPlayer;
		protected readonly GameInputManager gameInputMng;

		// Constructor
		public BaseScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng)
		{
			this.gameData = gameData;
			this.controller = controller;
			this.resourceMng = resourceMng;
			this.stage = viewMng.Stage;
			this.ui = viewMng.UI;
			this.soundPlayer = viewMng.SoundPlayer;
			this.effectPlayer = viewMng.EffectPlayer;
			this.gameInputMng = viewMng.GameInputMng;
		}

		public abstract void Load();

		public abstract void Start();

		public virtual void Update()
		{
			this.stage.Update();
		}

		public abstract void End();
		
	}
}
