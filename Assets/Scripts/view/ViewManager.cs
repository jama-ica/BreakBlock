using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View
{

	/// <summary>
	/// 
	/// </summary>
	public class ViewManager
	{
		GameInputManager gameInputMng;

		// Constructor
		public ViewManager()
		{
			var inputDeviceMng = new InputDeviceManager();
			this.gameInputMng = new GameInputManager(inputDeviceMng);
		}

		public void Update()
		{

		}

		
		
	}
}
