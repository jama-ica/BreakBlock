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
	public class GameScene : BaseScene
	{
		
		// Constructor
		public GameScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng)
			: base(gameData, controller, resourceMng, viewMng)
		{
		}

		public override void Load()
		{
			
		}

		public override void Start()
		{
			this.controller.StartStage();
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
