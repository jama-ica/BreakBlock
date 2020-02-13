using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View;
using RLTPS.View.Entity;

namespace RLTPS.Scene
{
	/// <summary>
	/// 
	/// </summary>
	public class TitleScene : BaseScene
	{
		readonly Controller controller;
		
		// Constructor
		public TitleScene( Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager, Subject<EScene> sbjChangeScene)
			: base(controller, resourceManager, viewManager, entityManager, sbjChangeScene)
		{
			this.controller = controller;
		}

		public override void Init()
		{

		}

		public override void LoadStart()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public override bool LoadUpdate(float deltaTime)
		{
			return false;
		}
		
		public override void Start()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			
			this.controller.StartTitle();
		}

		public override bool Update(float deltaTime)
		{
			ChangeSceneTo(EScene.Game);
			return false;
		}

		public override void EndStart()
		{
		}

		public override bool EndUpdate(float deltaTime)
		{
			return false;
		}


	}
}