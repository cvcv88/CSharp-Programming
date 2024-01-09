namespace _06._UserDefineType_Task
{
	enum Insert { left = 37, up, right, down }

	struct InputPos
	{
		public int x;
		public int y;
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			InputPos inputPos = new InputPos();
			int temp = 0;
			const int LEN = 5;

			int[,] slideArr = new int[LEN, LEN];
			for (int i = 0; i < LEN; i++)
			{
				for (int j = 0; j < LEN; j++)
				{
					slideArr[i, j] = (i * LEN) + j;
				}
			}
			while (true)
			{
				for (int i = 0; i < LEN; i++)
				{
					for (int j = 0; j < LEN; j++)
					{
						Console.Write($"{slideArr[i, j],10}");
					}
					Console.WriteLine("");
					Console.WriteLine("");
				}
				Console.WriteLine("왼쪽(←)  오른쪽(→)  위쪽(↑)  아래쪽(↓) : ");

				switch (Console.ReadKey().Key)
				{
					case (ConsoleKey.RightArrow):
						if (inputPos.x < LEN - 1)
						{
							temp = slideArr[inputPos.y, inputPos.x];
							slideArr[inputPos.y, inputPos.x] = slideArr[inputPos.y, inputPos.x + 1];
							slideArr[inputPos.y, inputPos.x + 1] = temp;
							inputPos.x++;
						}
						else
						{
						}
						break;
					case (ConsoleKey.LeftArrow):
						if (inputPos.x > 0)
						{
							temp = slideArr[inputPos.y, inputPos.x];
							slideArr[inputPos.y, inputPos.x] = slideArr[inputPos.y, inputPos.x - 1];
							slideArr[inputPos.y, inputPos.x - 1] = temp;
							inputPos.x--;
						}
						else
						{
						}
						break;
					case (ConsoleKey.UpArrow):
						if (inputPos.y > 0)
						{
							temp = slideArr[inputPos.y, inputPos.x];
							slideArr[inputPos.y, inputPos.x] = slideArr[inputPos.y - 1, inputPos.x];
							slideArr[inputPos.y - 1, inputPos.x] = temp;
							inputPos.y--;
						}
						else { }
						break;
					case (ConsoleKey.DownArrow):
						if (inputPos.y < LEN - 1)
						{
							temp = slideArr[inputPos.y, inputPos.x];
							slideArr[inputPos.y, inputPos.x] = slideArr[inputPos.y + 1, inputPos.x];
							slideArr[inputPos.y + 1, inputPos.x] = temp;
							inputPos.y++;
						}
						else { }
						break;
				}
				Console.Clear();
			}
		}
	}
}


