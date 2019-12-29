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
			//this.controller.StartTitle();

			//TODO
			var resource = new UIPrefabResource();
			var gameObj = resource.LoadOrGet(EUIPrefab.Title);
			var obj = GameObject.Instantiate(gameObj, new Vector3(0, 0, 0), Quaternion.identity);
			Assert.IsNotNull(obj);
			var t = obj.transform.Find("Panel/Text");
			Assert.IsNotNull(t);
			var text = t.GetComponent<UnityEngine.UI.Text>();
			Assert.IsNotNull(text);
			text.text = "あああ";
		}

		protected override void UpdateScene()
		{
			this.stage.Update();
		}

		protected override bool End()
		{
			return false;
		}

	}
}