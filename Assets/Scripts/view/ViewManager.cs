using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Resource;
using RLTPS.Control;
using RLTPS.Stage;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class ViewManager
	{
		readonly IGameData gameData;
		readonly Controller controller;
		readonly ResourceManager resourceMng;
		//
		public GameStage Stage {get;}
		public UIManager UI {get;}
		public SoundPlayer SoundPlayer {get;}
		public EffectPlayer EffectPlayer {get;}
		public GameInputManager GameInputMng {get;}

		// Constructor
		public ViewManager(IGameData gameData, Controller controller, ResourceManager resourceMng)
		{
			this.gameData = gameData;
			this.controller = controller;
			this.resourceMng = resourceMng;
			//
			this.Stage = new GameStage();
			this.UI = new UIManager();
			this.SoundPlayer = new SoundPlayer();
			this.EffectPlayer = new EffectPlayer();
			var inputDeviceMng = new InputDeviceManager();
			this.GameInputMng = new GameInputManager(inputDeviceMng);
		}

	}
}
