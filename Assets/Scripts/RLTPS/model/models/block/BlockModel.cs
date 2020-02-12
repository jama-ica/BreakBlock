using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BlockModel
	{
		readonly EBlockID _id;
		HpValue _hp;

		// Constructor
		public BlockModel(EBlockID id, int maxHp)
		{
			this._id = id;
			this._hp = new HpValue(maxHp);
		}

		public EBlockID ID { get { return this._id; } }

		public HpValue Hp { get { return this._hp; } }

		public bool IsDead()
		{
			return this._hp.IsZero();
		}
	}
}