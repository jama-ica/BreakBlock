using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller
	{
		readonly ModelFacade modelFacade;

		// Constructor
		public Controller(ModelFacade modelFacade)
		{
			this.modelFacade = modelFacade;
		}
		
		/*
			Create
		 */
		Subject<(ECreatedEvent type, IGameComponent component)> createdEvent = new Subject<(ECreatedEvent type, IGameComponent component)>();

		public IObservable<(ECreatedEvent type, IGameComponent component)> OnCreated() => this.createdEvent;

		void CreateTitle()
		{
			this.createdEvent.OnNext( (ECreatedEvent.Title, null) );
		}

		void CreateBar()
		{
			BarComponent bar = this.modelFacade.CreateBar();
			this.createdEvent.OnNext((ECreatedEvent.Bar, bar));
		}

		void CreateBall()
		{
			BallComponent ball = this.modelFacade.CreateBall();
			this.createdEvent.OnNext((ECreatedEvent.Bar, bar));
		}

		void CreateBlocks()
		{
			for(int i = 0 ; i < 10 ; i++)
			{
				for(int j = 0 ; j < 10 ; j++)
				{
					BlockComponent block = this.modelFacade.CreateBlock(i, j);
					this.createdEvent.OnNext((ECreatedEvent.Block, block));
				}
			}
		}


	}
}
