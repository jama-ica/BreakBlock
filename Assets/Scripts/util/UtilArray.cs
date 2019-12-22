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
		int count;

		// Constructor
		public UtilArray(int size)
		{
			this.buf = new T[size];
			this.head = 0;
			this.count = 0;
		}

		public readonly T[] List { get { return this.buf; } }

		public int Add(T item)
		{
			int index = Seek(this.head, this.buf);
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			Assert.IsNull(this.buf[index]);
			this.buf[index] = item;
			this.count++;
			this.head = index;
			return index;
		}

		public void Set(int index, T item)
		{
			Assert.IsTrue(0 <= index && index < this.buf.Length);
			if(this.buf[index] == null){
				this.count++;
			}
			this.buf[index] = item;
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
			this.count--;
			if(this.head > index){
				this.head = index;
			}
		}

		public int Size()
		{
			return this.buf.Length;
		}

		public int Count()
		{
			return this.count;
		}

		public void Clear()
		{
			for(int i = 0 ; i < this.buf.Length ; i++){
				this.buf[i] = null;
			}
			this.count = 0;
			this.head = 0;
		}

		private int Seek(int head, T[] buf)
		{
			for(int i = head ; i < buf.Length ; i++){
				if( buf[i] == null ){
					return i;
				}
			}
			return this.buf.Length;
		}
		
	}
}