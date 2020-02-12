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
	public partial class Controller // for Block
	{

		void Damage(ref BlockModel block)
		{
			int val = 1;
			block.Hp.Reduce(val);
		}

	}
}
