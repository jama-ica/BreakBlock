using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller // for Game
	{
	
		public void StartStage()
		{
			CreateBar();
			CreateBall();
			CreateBlocks();
		}
		

	}
}
