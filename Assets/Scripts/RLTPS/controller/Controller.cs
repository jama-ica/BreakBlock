using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Util;
using RLTPS.Resource;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller
	{
		readonly GameModel gameModel;
		readonly ResourceManager resourceManager;
		IViewCommandSender viewCommandSender;

		// Constructor
		public Controller(GameModel gameModel, ResourceManager resourceManager)
		{
			this.gameModel = gameModel;
			this.resourceManager = resourceManager;
			this.viewCommandSender = null;
		}

		public void Init(IViewCommandSender viewCommandSender)
		{
			this.viewCommandSender = viewCommandSender;
		}

		public void InitLoad()
		{
			// master data
			RLTPS.Model.MasterData masterData = this.resourceManager.MasterData.Load();

			// config data
			var config = this.resourceManager.ConfigData.Load();
			gameModel.SetConfigData(config);
			this.viewCommandSender.InitKeyConfig(config.KeyData);

			// save data
			this.resourceManager.SaveData.Load();
		}
		
	}
}
