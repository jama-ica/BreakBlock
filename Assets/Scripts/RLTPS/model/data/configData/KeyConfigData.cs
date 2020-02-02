using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class KeyConfigData
	{
		public Dictionary<int, EGameInput> KeyMap { get; private set; }

		// Constructor
		public KeyConfigData()
		{
			this.KeyMap = new Dictionary<int, EGameInput>();
		}

		public void ClearAll()
		{
			this.KeyMap.Clear();
		}

		public void SetPair(KeyCode keyCode, EGameInput gameInput)
		{
			this.KeyMap[(int)keyCode] = gameInput;
		}

		// // Keyと値を両方列挙する
		// foreach(KeyValuePair<int, string> item in theTable)
		// {
		// 	// KeyValurPair<TKey, TValue> という型となるので　.Key と .Valur を使用してキーと値にアクセスする
		// 	Console.WriteLine($"{item,Key} {Item.Value}, "); // 0 None, 1 One, 2 Tow, と表示される
		// }

		// // キー値のみ列挙する：Keys プロパティを in の右側に置く
		// foreach(int item in theTable.Keys)
		// {
		// 	Console.WriteLine(item); // 0, 1, 2 と表示される
		// }

		// // 値のみ列挙する：Values プロパティを in の右側に置く
		// foreach(string item in theTable.Values)
		// {
		// 	Console.WriteLine(item); // None, One, Tow と表示される
		// }

	}
}