using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View;
using RLTPS.View.Entity;
using RLTPS.Resource;

namespace RLTPS.View.Command
{
	/// <summary>
	/// 
	/// </summary>
	public class ViewCommandProcessor : IViewCommandSender
	{
		readonly Controller controller;
		readonly ResourceManager resourceManager;
		readonly ViewManager viewManager;
		readonly EntityManager entityManager;
		
		// Constructor
		public ViewCommandProcessor(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager)
		{
			this.controller = controller;
			this.resourceManager = resourceManager;
			this.viewManager = viewManager;
			this.entityManager = entityManager;
		}

		/**
		 *	IViewCommandSender
		 */
		public void InitKeyConfig(KeyConfigData keyConfig)
		{
			this.viewManager.InputManager.InitKeyConfig(keyConfig);
		}


		public void CreateTitle()
		{
			//TODO
		}

		public void CreateBar(BarModel barModel)
		{
			var barEntity = new BarEntity(this.controller, this.resourceManager, this.viewManager, barModel);
			this.entityManager.Add(barEntity);
		}

		public void CreateBall(BallModel ballModel)
		{
			var ballEntity = new BallEntity(this.controller, this.resourceManager, this.viewManager, ballModel);
			this.entityManager.Add(ballEntity);
		}

		public void CreateBlocks(BlockModels blockModel)
		{
			var blockEntity = new BlockEntity(this.controller, this.resourceManager, this.viewManager, blockModel);
			this.entityManager.Add(blockEntity);
		}	
		
	}
}