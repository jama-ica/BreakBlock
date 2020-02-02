using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Resource;
using RLTPS.Control;
using RLTPS.Entity;
using RLTPS.View.Stage;
using RLTPS.View.Device;
using RLTPS.View.Input;
using RLTPS.View.Sound;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class ViewManager
	{
		readonly Controller controller;
		readonly ResourceManager resourceMng;
		//
		public GameStage Stage { get; }
		public UIManager UI { get; }
		public SoundPlayer SoundPlayer { get; }
		public EffectPlayer EffectPlayer { get; }
		public DeviceManager deviceMng { get; }
		public InputManager InputMng { get; }
		public GameEntityManager GameEntityMng { get; }

		// Constructor
		public ViewManager(Controller controller, ResourceManager resourceMng)
		{
			this.controller = controller;
			this.resourceMng = resourceMng;
			//
			this.Stage = new GameStage();
			this.UI = new UIManager();
			this.SoundPlayer = new SoundPlayer();
			this.EffectPlayer = new EffectPlayer();
			this.deviceMng = new DeviceManager();
			this.InputMng = new InputManager(deviceMng);
			this.GameEntityMng = new GameEntityManager(controller, this);
		}


	}
}
