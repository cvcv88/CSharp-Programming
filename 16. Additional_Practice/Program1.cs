using System.Runtime.CompilerServices;

namespace _16._Additional_Practice
{
	internal static class Program1
	{
		public static int WordCount(this string str)
		{
			return str.Split(' ').Length;
		}
		public static int isEven1(this int num)
		{
			if (num % 2 == 0) return 1;
			else return 0;
		}
		public static bool isEven(this int value)
		{
			return value % 2 == 0;
		}
		static void Main(string[] args)
		{
			string str = "abc de";
			int count1 = WordCount(str);

			int num = 5;
			int count2 = isEven1(num);

			int value = 3;
			bool isEven = value.isEven();
			Console.WriteLine($"WordCount({str}) : {count1}");
			Console.WriteLine($"isEven1({num})(true 1, false 0) : {count2}");
			Console.WriteLine($"isEven({value})(true 1, false 0) : {isEven}");
		}
	}
}
