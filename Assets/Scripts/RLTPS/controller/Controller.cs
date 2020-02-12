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
			// config
			var configData = this.resourceManager.ConfigData.Load();
			gameModel.SetConfigData(configData);
			this.viewCommandSender.InitKeyConfig(configData.KeyData);//TODO

			this.resourceManager.MasterData.Load();
			this.resourceManager.SaveData.Load();
		}
		
		// /*
		// 	Created Event
		//  */
		// Subject<(ECreatedEvent type, IGameComponent component)> createdEvent = new Subject<(ECreatedEvent type, IGameComponent component)>();
		// public IObservable<(ECreatedEvent type, IGameComponent component)> OnCreated() => this.createdEvent;

		// // Subject<(ECreatedEvent type, UtilArray<IGameComponent> components)> createdArrayEvent = new Subject<(ECreatedEvent type, UtilArray<IGameComponent> components)>();
		// // public IObservable<(ECreatedEvent type, UtilArray<IGameComponent> components)> OnCreatedArray() => this.createdArrayEvent;

		// void CreateTitle()
		// {
		// 	this.createdEvent.OnNext( (ECreatedEvent.Title, null) );
		// }

		void CreateBall()
		{
			//TODO
		}

		void CreateBlocks()
		{
			//TODO
		}

	}
}
