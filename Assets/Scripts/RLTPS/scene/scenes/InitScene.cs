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

namespace RLTPS.Scene
{
	
	/// <summary>
	/// 
	/// </summary>
	public class InitScene : BaseScene
	{
		
		// Constructor
		public InitScene(Controller controller, ResourceManager resourceManager, ViewManager viewManager, EntityManager entityManager, Subject<EScene> sbjChangeScene)
			: base(controller, resourceManager, viewManager, entityManager, sbjChangeScene)
		{
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
			Debug.Log("Called: " + this.GetType().Name + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public override bool Update()
		{
			ChangeSceneTo(EScene.Title);
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
