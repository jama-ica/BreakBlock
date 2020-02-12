using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class HpValue
	{
		int _val;
		int _maxVal;

		// Constructor
		public HpValue(int maxValue)
		{
			this._maxVal = maxValue;
			this._val = maxValue;
		}

		public int MaxValue { get{ return this._maxVal; } }
		
		public int Value { get { return this._val; } }

		public void Init(int maxValue)
		{
			this._maxVal = maxValue;
			this._val = maxValue;
		}

		public void Reduce(int val)
		{
			this._val = (val <= this._val) ? this._val - val : 0;
		}

		public bool IsZero()
		{
			return (this._val == 0);
		}

		public void Recover(int val)
		{
			this._val = (this._val + val <= this._maxVal) ? this._val + val  : this._maxVal;
		}

		public void AddMaxValue(int val)
		{
			this._maxVal += val;
		}

	}
}