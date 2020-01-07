using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class GameStage
	{
		//StageCamera camera;
		UtilArray<BaseUIStageObject> uiObjs;
		
		// Constructor
		public GameStage()
		{
			this.uiObjs = new UtilArray<BaseUIStageObject>(100);
		}

		public void Update()
		{
			for( int i = 0, size = this.uiObjs.Count() ; i < size ; i++ )
			{
				var obj = this.uiObjs.Get(i);
				if( obj is null ){
					continue;
				}
				obj.Update();
			}
		}

		public void ClearAll()
		{
			this.uiObjs.Clear();
		}

		public EUIID Stage(BaseUIStageObject stageObj)
		{
			GameObject newGameObj = GameObject.Instantiate(stageObj.GameObj, new Vector3(0, 0, 0), Quaternion.identity);
			stageObj.SetGameObj(newGameObj);
			stageObj.Start();
			return (EUIID)this.uiObjs.Add(stageObj);
		}

		public BaseUIStageObject GetUIStageObject(EUIID id)
		{
			return this.uiObjs.Get((int)id);
		}

		public void UnStage(EUIID id)
		{
			this.uiObjs.Remove((int)id);
		}

	}
}