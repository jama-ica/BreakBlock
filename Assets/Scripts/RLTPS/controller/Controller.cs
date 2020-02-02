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
		readonly GameModel GameModel;
		readonly ResourceManager resourceMng;
		IViewCommand viewCommand;

		// Constructor
		public Controller(GameModel GameModel, ResourceManager resourceMng)
		{
			this.GameModel = GameModel;
			this.resourceMng = resourceMng;
			this.viewCommand = null;
		}

		public void Init(IViewCommand viewCommand)
		{
			this.viewCommand = viewCommand;
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
