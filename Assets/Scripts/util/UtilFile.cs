using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class UtilFile
	{
		
		// Constructor
		private UtilFile()
		{
		}

		public static void Write(string filePath, string text)
		{
			var encoding = System.Text.Encoding.GetEncoding("UTF-8");
			using (StreamWriter sw = new StreamWriter(filePath, false, encoding))
			{
				sw.WriteLine("Hello World!");
			}
		}

		public static string Read(string filePath)
		{
			var encoding = System.Text.Encoding.GetEncoding("UTF-8");
			using (var reader = new System.IO.StreamReader(filePath, encoding))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
				}
			}
			return "";
		}
		
		
	}
}