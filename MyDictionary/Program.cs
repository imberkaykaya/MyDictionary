using System;
using System.Collections.Generic;


namespace MyDictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<string> Cars = new MyDictionary<string>();

			Cars.Add("TOGG");
			Cars.Add("TESLA");
			Cars.Add("Renault");

			foreach (var i in Cars.Items)
			{
				Console.WriteLine(i);
			}
		}
	}
}