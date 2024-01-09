namespace _04._Loop_Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 별 찍기!!!!
			// 1번
			Console.Write("숫자를 입력해주세용 : ");
			int num = int.Parse(Console.ReadLine());
			for (int i = 0; i < num; i++)
			{
				Console.Write("*");
			}

			Console.WriteLine("");
			Console.WriteLine("");

			// 2번
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("");
			Console.WriteLine("");

			// 3번
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; i > j - 1; j++) // 0 0, 1 0, 2 0, 3 0, 4 0
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("");
			Console.WriteLine("");

			// 4번
			for (int i = num; i > 0; i--)
			{
				for (int j = 0; j < i; j++) // 5 0, 4 0, 3 0, 2 0, 1 0 
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("");
			Console.WriteLine("");

			// 5번 윗부분
			for (int i = 0; i < num; i++)
			{
				for (int j = num; j > i; j--)
				{
					Console.Write(" ");
				}

				for (int k = 0; k < (i + 1) * 2 - 1; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine("");
			}

			// 5번 밑부분
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; i > j - 1; j++)
				{
					Console.Write(" ");
				}

				for (int k = 0; k < ((num - i) * 2) - 1; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine("");
			}


			// 5번 완전체 헐 -4~0~4, 중간으로부터 거리가 4인 별들.
			/*for(int i = num; i <= num; i++)
			{
				int abs1 = i > 0 ? 1 : -1;
				for(int j = 0; j < abs1; j++)
				{
					Console.Write(" ");
				}

			}*/
		}
	}
}