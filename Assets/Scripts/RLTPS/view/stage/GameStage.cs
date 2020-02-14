using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class GameStage
	{
		//StageCamera camera;
		UtilList<BaseUIStageObject> uiObjs;
		UtilList<StageObject> modelObjs;
		
		// Constructor
		public GameStage()
		{
			this.uiObjs = new UtilList<BaseUIStageObject>(100);
			this.modelObjs = new UtilList<StageObject>(100);
		}

		public void ClearAll()
		{
			this.uiObjs.Clear();
			this.modelObjs.Clear();
		}

		public void Stage(StageObject stageObj)
		{
			GameObject srcObj = stageObj.SrcObj;
			Assert.IsNotNull(srcObj);
			GameObject newGameObj = GameObject.Instantiate(srcObj, new Vector3(0, 0, 0), Quaternion.identity);
			stageObj.SetGameObj(newGameObj);
			stageObj.Start();
			this.modelObjs.Add(stageObj);
		}

		public void UnStage(StageObject stageObj)
		{
			this.modelObjs.Remove(stageObj);
			UnityEngine.Object.Destroy(stageObj.GameObj);
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