namespace _06._UserDefineType_Practice_Solution
{
	internal class Program
	{
		enum RPS { Rock, Paper, Scissor }
		static bool IsGameOver(int playerWin, int computerWin)
		{
			bool playerComplete = playerWin >= 3;
			bool computerComplete = computerWin >= 3;
			return playerComplete || computerComplete;
		}

		static RPS PlayerInput()
		{
			RPS result = RPS.Rock;
			// 1 가위, 2 바위, 3 보
			Console.WriteLine("가위 바위 보 중에서 하나를 선택하세요.");
			Console.WriteLine("1. 가위, 2. 바위, 3. 보"); ;
			Console.Write(" → ");

			ConsoleKeyInfo info = Console.ReadKey();
			switch (info.Key)
			{
				// 가위 선택
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					result = RPS.Scissor;
					break;

				// 바위 선택
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					result = RPS.Rock;
					break;

				// 보 선택
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					result = RPS.Paper;
					break;
			}
			return result;
		}

		static RPS COmputerRandom()
		{
			Random rand = new Random();
			int value = rand.Next(0, 3);
			RPS result = (RPS)value;

			return result;
		}

		enum WinOrLose { Win, Draw, Lose }

		static WinOrLose CalculateBatter(RPS player, RPS computer)
		{
			// 나 가위, 컴 가위	: 무승부
			// 나 가위, 컴 바위	: 패
			// 나 가위, 컴 보	: 승
			if (player == RPS.Scissor && computer == RPS.Rock ||
					player == RPS.Rock && computer == RPS.Paper ||
					player == RPS.Paper && computer == RPS.Scissor)
			{
				return WinOrLose.Lose;
			}
			else if (player == RPS.Rock && computer == RPS.Scissor ||
					player == RPS.Scissor && computer == RPS.Paper ||
					player == RPS.Paper && computer == RPS.Rock)
			{
				return WinOrLose.Win;
			}
			else
			{
				return WinOrLose.Draw;
			}
		}

		static void PrintResult(RPS player, RPS computer, WinOrLose result, int playerWin, int computerWin)
		{
			Console.WriteLine();
			Console.WriteLine($"플레이어 : {player}");
			Console.WriteLine($"컴퓨터 : {computer}");
			Console.WriteLine($"결과 : {result}");
			Console.WriteLine();
			Console.WriteLine($"승패 : 나의 승리 {playerWin}회, 컴퓨터의 승리 {computerWin}회\n");
		}

		static void PrintGameEnd(int playerWin, int computerWin)
		{
			if (playerWin == 3)
			{
				// 플레이어 승리
				Console.WriteLine("플레이어가 승리했습니다!");
			}
			else if (computerWin == 3)
			{
				// 컴퓨터 승리
				Console.WriteLine("컴퓨터가 승리했습니다!");
			}
		}
		static void Main(string[] args)
		{
			int playerWin = 0;
			int computerWin = 0;

			// == while(!IsGameOver(playerWin,computerWin)){ }
			// == !(playerWin>=3 || computerWin >=3
			while (playerWin < 3 && computerWin < 3)
			{
				// 1. 플레이어에게 가위 바위 보 입력 받기
				RPS player = PlayerInput();
				// 2. 컴퓨터는 랜덤으로 낸다
				RPS computer = COmputerRandom();
				// 3. 가위바위보 승패 계산한다.
				WinOrLose result = CalculateBatter(player, computer);

				if (result == WinOrLose.Win)
				{
					playerWin++;
				}
				else if (result == WinOrLose.Lose)
				{
					computerWin++;
				}
				PrintResult(player, computer, result, playerWin, computerWin);
			}
			PrintGameEnd(playerWin, computerWin);
		}
	}
}