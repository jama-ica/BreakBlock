using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// This UtilList does not keep order of items in the list.
	/// </summary>
	public class UtilList<T> where T : class
	{
		
		T[] buf;
		int tail;

		// Constructor
		public UtilList(int capacity)
		{
			this.buf = new T[capacity];
			this.tail = 0;
		}

		public T[] Array { get { return this.buf; } }

		public int Size { get { return this.tail; } }

		public int Capacity { get { return this.buf.Length; } }

		public T Get(int index)
		{
			Assert.IsTrue(0 <= index && index < this.tail);
			return this.buf[index];
		}

		public void Add(T item)
		{
			Assert.IsTrue(this.tail < this.buf.Length);
			Assert.IsNull(this.buf[this.tail]);
			this.buf[this.tail] = item;
			this.tail++;
		}

		public void Add(UtilList<T> list)
		{
			T[] array = list.Array;
			for(int i = 0, size = list.Size; i < size ; i++)
			{
				Add(array[i]);
			}
		}

		public void Remove(T item)
		{
			Assert.IsNotNull(item);
			for(int i = 0 ; i < this.tail ; i++)
			{
				if(!object.ReferenceEquals(item, this.buf[i])){
					continue;
				}
				Remove(i);
				return;
			}
			Assert.IsTrue(true, "Not found");
		}

		public void Remove(int index)
		{
			Assert.IsTrue(0 <= index && index < this.tail);
			if(index == this.tail-1){
				this.buf[this.tail-1] = null;
			}else{
				this.buf[index] = this.buf[this.tail-1];
				this.buf[this.tail-1] = null;
			}
			this.tail--;
		}

		public void Clear()
		{
			for(int i = 0 ; i < this.tail ; i++){
				this.buf[i] = null;
			}
			this.tail = 0;
		}

		public bool IsEmpty()
		{
			return (0 == this.tail);
		}


	}
}