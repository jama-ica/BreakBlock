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
		public ViewStage Stage { get; private set; }
		public SoundPlayer SoundPlayer { get; private set; }
		public EffectPlayer EffectPlayer { get; private set; }
		public InputManager InputManager { get; private set; }

		// Constructor
		public ViewManager(ResourceManager resouceManager, DeviceManager deviceManager)
		{
			this.Stage = new ViewStage();
			this.SoundPlayer = new SoundPlayer(resouceManager.Sound);
			this.EffectPlayer = new EffectPlayer(resouceManager.Effect);
			this.InputManager = new InputManager(deviceManager);
		}


	}
}
