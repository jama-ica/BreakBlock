using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class UtilArray<T> where T : class
	{
		
		readonly T[] buf;
		int head;
		int size;

		// Constructor
		public UtilArray(int limit)
		{
			this.buf = new T[limit];
			this.head = 0;
			this.size = 0;
		}

		public T[] List { get { return this.buf; } }

		public int Size { get { return this.size; } }

		public int Limit { get { return this.buf.Length; } }

		public int Add(T item)
		{
			int index = Seek(this.head, this.buf);
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			Assert.IsNull(this.buf[index]);
			this.buf[index] = item;
			this.head = index;
			if(index >= this.size){
				this.size = index + 1;
			}
			return index;
		}

		public void Set(int index, T item)
		{
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			this.buf[index] = item;
			if(index >= this.size){
				this.size = index + 1;
			}
		}

		public T Get(int index)
		{
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			return this.buf[index];
		}

		public void Remove(int index)
		{
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			if(this.buf[index] == null){
				return;
			}
			this.buf[index] = null;
			// head
			if(this.head > index){
				this.head = index;
			}
			// size
			if(index + 1 >= this.size){
				this.size = index;
			}
		}


		public void Clear()
		{
			for(int i = 0 ; i < this.buf.Length ; i++){
				this.buf[i] = null;
			}
			this.head = 0;
			this.size = 0;
		}

		private int Seek(int head, T[] buf)
		{
			for(int i = head ; i < buf.Length ; i++){
				if( buf[i] == null ){
					return i;
				}
			}
			Assert.IsTrue(true);
			return this.buf.Length;
		}
		
	}
}