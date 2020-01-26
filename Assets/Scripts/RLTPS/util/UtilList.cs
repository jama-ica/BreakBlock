using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class UtilList<T> where T : class
	{
		
		T[] buf;
		int tail;

		// Constructor
		public UtilList(int limit)
		{
			this.buf = new T[limit];
			this.tail = 0;
		}

		public T[] List { get { return this.buf; } }

		public int Size { get { return this.tail; } }

		public void Add(T item)
		{
			Assert.IsTrue(this.tail < this.buf.Length);
			Assert.IsNull(this.buf[this.tail]);
			this.buf[this.tail] = item;
			this.tail++;
		}

		public void Remove(T item)
		{
			Assert.IsNotNull(item);
			for(int i = 0 ; i < this.tail ; i++)
			{
				if(!object.ReferenceEquals(item, this.buf[i])){
					continue;
				}
				if(i == this.tail-1){
					this.buf[this.tail-1] = null;
				}else{
					this.buf[i] = this.buf[this.tail-1];
					this.buf[this.tail-1] = null;

				}
				this.tail--;
				return;
			}
			Assert.IsTrue(true, "Not found");
		}

		public void Clear()
		{
			for(int i = 0 ; i < this.tail ; i++){
				this.buf[i] = null;
			}
			this.tail = 0;
		}


	}
}