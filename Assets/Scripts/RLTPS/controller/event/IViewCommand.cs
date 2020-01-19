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
	public interface IViewCommand
	{
		void CreateTitle();
		void CreateBar(BarModel bar);
		void CreateBall(BallModel ball);
		void CreateBlock(BlockModel block);
	}
}