using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class Rand : IRand
	{
		Random random;

		// Constructor
		public Rand()
		{
			this.random = null;
		}

		public void Init(int seed)
		{
			this.random = new Random(seed);
			// Environment.TickCount
		}

		// get random num (min <= num < max) 
		public int Range(int min, int max)
		{
			Assert.IsTrue(min <= max);
			return this.random.Next(min, max);
		}

		// get random num (0 <= num < max) 
		public int Next(int max)
		{
			if(max == 0){
				return 0;
			}
			return this.random.Next(max);
		}

		public int Next()
		{
			return this.random.Next();
		}

		public double NextAsDouble()
		{
			return this.random.NextDouble();
		}

		// select
		public Type Lot<Type>(List<Type> list)
		{
			if( list.Count == 0 ){
				Assert.IsTrue(false);
			}
			int index = this.next(list.Count);
			return list[index];
		}

		public (int index, int no) LotWithWeight(List<(int index, int weight)> list)
		{
			int sum = 0;
			foreach(var item in list){
				sum += item.weight;
			}
			int lot = this.next(sum);
			sum = 0;
			foreach(var item in list){
				if(sum + item.weight < lot){
					sum += item.weight;
					continue;
				}
				return (item.index, lot - sum);
			}
			Assert.IsTrue(false);
			return (-1, -1);

		}

		// lot rate / max;
		public bool Lot(int rate, int max)
		{
			return this.next(max) < rate;
		}
		
		// get shuffled order slist (list.Count = size) 
		public List<int> Order(int size)
		{
			List<int> list = new List<int>(size);
			for(int i = 0 ; i < size ; i++){
				list[i] = i;
			}
			return shuffle(list);
		}

		// get shuffled list
		public List<Type> Shuffle<Type>(List<Type> list)
		{
			Type temp;
			for(int i = 0, size = list.Count ; i < size ; i++){
				int r = this.next(size);
				temp = list[r];
				list[r] = list[i];
				list[i] = temp;
			}
			return list;
		}



	}
}