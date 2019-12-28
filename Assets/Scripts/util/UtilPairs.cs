using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class UtilPairs<T> where T : class
	{
		readonly T[] buf;

		// Constructor
		public UtilPairs((int key, T val)[] list)
		{
			int size = GetMaxKey(list) + 1;
			Assert.IsTrue(0 < size);
			Assert.IsTrue(list.Length <= size);
			
			this.buf = new T[size];
			for(int i = 0 ; i < list.Length ; i++)
			{
				(int key, T val) item = list[i];
				Assert.IsTrue(0 <= item.key && item.key < this.buf.Length);
				this.buf[item.key] = item.val;
			}
		}

		public T GetItem(int key)
		{
			Assert.IsTrue( 0 <= key && key < this.buf.Length );
			return this.buf[key];
		}

		private int GetMaxKey((int key, T val)[] list)
		{
			int max = 0;
			for(int i = 0 ; i < list.Length ; i++) {
				var item = list[i];
				if(max < item.key) {
					max = item.key;
				}
			}
			return max;
		}
		
	}
}