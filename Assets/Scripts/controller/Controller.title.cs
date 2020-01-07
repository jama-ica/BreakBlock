using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Model;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller // for Title
	{

		public void StartTitle()
		{
			CreateTitle();
		}

		Subject<(ECreatedEvent type, IGameComponent component)> createdEvent = new Subject<(ECreatedEvent type, IGameComponent component)>();

		public IObservable<(ECreatedEvent type, IGameComponent component)> OnCreated() => this.createdEvent;

		private void CreateTitle()
		{
			this.createdEvent.OnNext( (ECreatedEvent.Title, null) );
		}

		private void CreateBar()
		{
			BarComponent bar = this.modelFacade.CreateBar();
			this.createdEvent.OnNext((ECreatedEvent.Bar, bar));
		}


	}
}
