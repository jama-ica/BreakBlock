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
	public partial class Controller // for Title
	{

		public void StartTitle()
		{
			this.viewCommandSender.CreateTitle();
		}




	}
}
