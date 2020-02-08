using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.View.Entity;
using RLTPS.View.Input;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseScene
	{

		protected readonly Subject<EScene> sbjChangeScene;

		// Constructor
		public BaseScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, Subject<EScene> sbjChangeScene)
		{
			this.sbjChangeScene = sbjChangeScene;
		}


		public abstract void Init();

		public abstract void LoadStart();

		public abstract bool LoadUpdate();

		public abstract void Start();

		public abstract bool Update();
		// this.InputManager.Update();
		// this.EntityManager.Update();

		public abstract void EndStart();

		public abstract bool EndUpdate();


		protected void ChangeSceneTo(EScene type)
		{
			this.sbjChangeScene.OnNext(type);
		}
		
	}
}
