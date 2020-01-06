using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Resource;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class TitleUI : StageObject
	{
		
		// Constructor
		public TitleUI()
		{
		}

		public string GetPath()
		{
			return EUIPrefab.Title.ToPath();
		}

		
	}
}