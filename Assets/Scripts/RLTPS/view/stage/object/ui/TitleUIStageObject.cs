using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class TitleUIStageObject : BaseUIStageObject
	{
		
		readonly UIPrefabResource resource;

		// Constructor
		public TitleUIStageObject(UIPrefabResource resource)
			: base()
		{
			this.resource = resource;
		}

		public override void Load(ResourceManager resourceManager)
		{
			//TODO resource.LoadOrGet(EUIPrefabType.Title);
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

		public bool Update()
		{
			return true;
		}
	}
}