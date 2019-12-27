using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BlockData
	{
		public int hp { get; protected set; }

		// Constructor
		public BlockData(int hp)
		{
			this.hp = hp;
		}

		public void DecHp(int val)
		{
			if(this.hp < val){
				this.hp = 0;
				return;
			}
			this.hp -= val;
		}
		
	}
}