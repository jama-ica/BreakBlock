using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Resource
{
	/// <summary>
	/// 
	/// </summary>
	public class ResourceManager
	{
		public UIResource UI { get; }
		
		// Constructor
		public ResourceManager()
		{
			this.UI = new UIResource();
		}

		
		
	}
}