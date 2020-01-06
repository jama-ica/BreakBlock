using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Unity;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class GameStage
	{
		UnityStage unityStage;

		public IGameStage()
		{
			this.unityStage = new UnityStage();
		}

		public void Stage(StageObject stageObj)
		{
			this.unityStage.Stage(stageObj.GameObj);
		}

		public void UnStage()
		{
			//TODO this.unityStage.UnStage();
		}
	}
}