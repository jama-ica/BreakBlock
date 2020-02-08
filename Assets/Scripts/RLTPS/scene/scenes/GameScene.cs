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

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public class GameScene : BaseScene
	{
		readonly Controller controller;

		// Constructor
		public GameScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, Subject<EScene> sbjChangeScene)
			: base(controller, resourceManager, viewManager, sbjChangeScene)
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

		public override bool LoadUpdate()
		{
			return false;
		}

		public override void Start()
		{
			this.controller.StartStage();
		}

		public override bool Update()
		{
			return false;
		}

		public override void EndStart()
		{
		}

		public override bool EndUpdate()
		{
			return false;
		}
	}
}
