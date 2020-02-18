using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.LevelData;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class BlockModel
	{
		EBlockID _id;
		int _x;
		int _y;
		HpValue _hp;

		// Constructor
		public BlockModel(EBlockID id, BlockData data)
		{
			this._id = id;
			this._x = data.X;
			this._y = data.Y;
			this._hp = new HpValue(data.Hp);
		}

		public EBlockID Id { get { return this._id; } }

		public int X { get { return this._x; } }

		public int Y { get { return this._y; } }
		
		public HpValue Hp { get { return this._hp; } }

		public bool IsDead()
		{
			return this._hp.IsZero();
		}
	}
}