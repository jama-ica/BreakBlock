using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.Control
{
	/// <summary>
	/// 
	/// </summary>
	public interface IViewCommandSender
	{
		void InitKeyConfig(KeyConfigData keyConfig);

		void CreateTitle();
		void CreateBar(BarModel bar);
		void CreateBall(BallModel ball);
		void CreateBlocks(BlocksModel block);
	}
}