using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDictionary
{
	internal class MyDictionary<T>
	{
		T[] items;
		public MyDictionary()
		{
			items = new T[0]; //
		}
		public void Add(T item)
		{
			T[] tempArray = items; //geçici değişken 
			items = new T[items.Length + 1]; //yeni gelecek değer --> dizi boyutunu bir arttırarak geliyor.

			for (int i = 0; i < tempArray.Length; i++)
			{
				items[i] = tempArray[i]; //geçici değişkendeki verileri kendi dizimize tekrar alıyoruz.
			}
			items[items.Length - 1] = item; //atanacak yeni değeri son elemana eklemek için.
		}

		public int Length
		{
			get { return items.Length; }
		}
		public T[] Items
		{
			get { return items; }
		}
	}
}
