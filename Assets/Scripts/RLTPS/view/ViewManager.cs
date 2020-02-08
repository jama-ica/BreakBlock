using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Resource;
using RLTPS.Control;
using RLTPS.View.Entity;
using RLTPS.View.Stage;
using RLTPS.Device;
using RLTPS.View.Input;
using RLTPS.View.Sound;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class ViewManager
	{
		public GameStage Stage { get; private set; }
		public UIManager UI { get; private set; }
		public SoundPlayer SoundPlayer { get; private set; }
		public EffectPlayer EffectPlayer { get; private set; }
		public InputManager InputManager { get; private set; }

		// Constructor
		public ViewManager(DeviceManager deviceManager)
		{
			this.Stage = new GameStage();
			this.UI = new UIManager();
			this.SoundPlayer = new SoundPlayer();
			this.EffectPlayer = new EffectPlayer();
			this.InputManager = new InputManager(deviceManager);
		}


	}
}
