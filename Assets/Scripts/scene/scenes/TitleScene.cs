using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Stage;
using RLTPS.View;

namespace RLTPS.Scene
{
	/// <summary>
	/// 
	/// </summary>
	public class TitleScene : BaseScene
	{
		// Constructor
		public TitleScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng)
			: base(gameData, controller, resourceMng, viewMng)
		{
		}

		public override void Load()
		{
			//TODO
		}
		
		public override void Start()
		{
			this.controller.StartTitle();
		}

		public override void Update()
		{
			this.stage.Update();
		}

		public override void End()
		{

		}

	}
}