using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Util;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public class GameEntityManager : IViewCommand
	{
		readonly Controller controller;
		readonly ViewManager viewMng;
		//--
		UtilList<BaseGameEntity> entities;
		UtilList<BaseUpdatableGameEntity> updatableEntities;

		// Constructor
		public GameEntityManager(Controller controller, ViewManager viewMng)
		{
			this.controller = controller;
			this.viewMng = viewMng;
			//
			this.entities = new UtilList<BaseGameEntity>(100);
			this.updatableEntities = new UtilList<BaseUpdatableGameEntity>(100);
		}

		public void Update()
		{
			BaseUpdatableGameEntity[] list = this.updatableEntities.List;
			for(int i = 0, size = this.updatableEntities.Size ; i < size ; i ++)
			{
				list[i].Update();
			}
		}

		/**
		 *	ICommand
		 */
		public void CreateTitle()
		{

		}

		public void CreateBar(BarModel bar)
		{
			var barEntity = new BarEntity(this.controller, this.viewMng);
			this.updatableEntities.Add(barEntity);
		}

		public void CreateBall(BallModel ball)
		{
			//TODO
		}

		public void CreateBlock(BlockModel block)
		{
			//TODO
		}	
	}
}