using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class TitleUIStageObject : BaseUIStageObject
	{
		
		public static TitleUIStageObject Create(UIResource resource)
		{
			var gameObj = resource.LoadOrGet(EUIResourceType.Title);
			return new TitleUIStageObject(gameObj);
		}

		// Constructor
		public TitleUIStageObject(GameObject gameObj)
			: base(gameObj)
		{

		}

		public override void Start()
		{
			var t = this.GameObj.transform.Find("Panel/Text");
			var text = t.GetComponent<UnityEngine.UI.Text>();
			text.text = "あああ";

			var b = this.GameObj.transform.Find("Panel/Button");
			var button = b.GetComponent<UnityEngine.UI.Button>();
			button.onClick.AddListener( () => {
				Debug.Log("You have clicked the button!");
			});
		}

		public override bool Update()
		{
			return true;
		}
	}
}