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
		Controller controller;
		ViewManager viewMng;
		//--
		UtilArray<BaseGameEntity> gameEntities;
		UtilArray<BaseUpdatableGameEntity> updatableEntities;

		// Constructor
		public GameEntityManager(Controller controller, ViewManager viewMng)
		{
			this.controller = controller;
			this.viewMng = viewMng;
			//
			this.gameEntities = new UtilArray<BaseGameEntity>(100);
			this.updatableEntities = new UtilArray<BaseUpdatableGameEntity>(100);
		}

		public void Update()
		{
			for(int i = 0 ; i < this.updatableEntities.Size() ; i ++)
			{
				this.updatableEntities.Get(i).Update();
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