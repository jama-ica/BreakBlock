using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Model;

namespace RLTPS.Control
{

	/// <summary>
	/// 
	/// </summary>
	public partial class Controller // for Bar
	{
		void CreateBar()
		{
			BarModel bar = this.GameModel.CreateBar();
			this.viewCommandSender.CreateBar(bar);
		}
	}
}
