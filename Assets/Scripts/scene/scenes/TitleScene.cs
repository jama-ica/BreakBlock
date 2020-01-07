using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
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
		public TitleScene(IGameData gameData, Controller controller, ResourceManager resourceMng, ViewManager viewMng, Subject<EScene> sbjChangeScene)
			: base(gameData, controller, resourceMng, viewMng, sbjChangeScene)
		{
		}

		protected override bool Load()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			return false;
		}
		
		protected override void Start()
		{
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			
			this.controller.OnCreated().Subscribe( args => {
				switch(args.type)
				{
				case ECreatedEvent.Title: StageTitleUI(); break;
				default:
					Debug.LogWarning("!type = " + args.type);
					break;
				}
			} );

			this.controller.StartTitle();
		}

		protected override void UpdateScene()
		{
			this.gameStage.Update();
		}

		protected override bool End()
		{
			return false;
		}

		void TaskOnClick()
		{
			//Output this to console when the Button is clicked
			Debug.Log("You have clicked the button!");
		}

		void StageTitleUI()
		{
			var stageObj = TitleUIStageObject.Create(this.resourceMng.UI);
			this.gameStage.Stage(stageObj);
		}

	}
}