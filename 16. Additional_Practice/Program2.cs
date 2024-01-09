using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Practice
{
	internal class Program2
	{
		public static void Swap<T>(ref T num1, ref T num2)
		{
			T temp = num1;
			num1 = num2;
			num2 = temp;
		}

		static void Main1(string[] args)
		{
			int num1 = 5;
			int num2 = 10;
			Console.WriteLine($"num1 : {num1}, num2 : {num2}");
			Swap<int>(ref num1, ref num2);
			Console.WriteLine($"num1 : {num1}, num2 : {num2}");

			Console.WriteLine();

			float num3 = 3.1f;
			float num4 = 5.9f;
			Console.WriteLine($"num3 : {num3}, num4 : {num4}");
			Swap<float>(ref num3, ref num4);
			Console.WriteLine($"num3 : {num3}, num4 : {num4}");
		}

	}
}
