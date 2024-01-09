using System.ComponentModel;
using System.Security.Principal;

namespace _04._Loop_Task
{
	internal class Program
	{
		// 컴퓨터랑 가위바위보
		/*static void Main(string[] args)
		{
			int mWin = 0, cWin = 0;
			int mLose = 0, cLose = 0;
			int mDraw = 0, cDraw = 0;

			do
			{
				Random rand = new Random();
				int bfRsp = rand.Next(1, 4);
				string afRsp = bfRsp.ToString();
				string realRsp = "";
				switch (afRsp)
				{
					case "1":
						realRsp = "가위";
						break;
					case "2":
						realRsp = "바위";
						break;
					case "3":
						realRsp = "보";
						break;
				}

				Console.Write("가위바위보 중 한 가지를 내보자! : ");
				string myRsp = Console.ReadLine();

				if (string.Equals(realRsp, myRsp))
				{
					Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
					Console.WriteLine("비겼습니당");
					mDraw++;
					cDraw++;
				}
				else if (realRsp == "가위")
				{
					switch (myRsp)
					{
						case ("보"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("졌습니다.....");
							mLose++;
							cWin++;
							break;
						case ("바위"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("이겼습니다!! 유후~~~");
							mWin++;
							cLose++;
							break;
					}
				}
				else if (realRsp == "바위")
				{
					switch (myRsp)
					{
						case ("가위"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("졌습니다.....");
							mLose++;
							cWin++;
							break;
						case ("보"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("이겼습니다!! 유후~~~");
							mWin++;
							cLose++;
							break;
					}
				}
				else if (realRsp == "보")
				{
					switch (myRsp)
					{
						case ("바위"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("졌습니다.....");
							mLose++;
							cWin++;
							break;
						case ("가위"):
							Console.WriteLine($"= 컴퓨터 : {realRsp} vs 나 : {myRsp}");
							Console.WriteLine("이겼습니다!! 유후~~~");
							mWin++;
							cLose++;
							break;
					}
				}
				if (mWin >= 3 || cWin >= 3)
				{
					break;
				}
				Console.WriteLine("");
				Console.WriteLine($"당신의 전적 : {mWin}승 {mLose}패 {mDraw}무");
				Console.WriteLine($"컴퓨터의 전적 : {cWin}승 {cLose}패 {cDraw}무");
				Console.WriteLine("");
			}
			while (true);

			if (mWin >= 3)
			{
				Console.WriteLine("당신이 컴퓨터를 이겼습니다! 푸하하하~");
			}
			else
			{
				Console.WriteLine("아주아주 아깝게 당신이 졌습니다.. 다음기회에!");
			}
			Console.WriteLine("<최종 전적>");
			Console.WriteLine($"당신의 전적 : {mWin}승 {mLose}패 {mDraw}무");
			Console.WriteLine($"컴퓨터의 전적 : {cWin}승 {cLose}패 {cDraw}무");
		}*/


		// 컴퓨터랑 숫자야구
		static void Main(string[] args)
		{
			Console.WriteLine("<숫자 야구>");
			Console.WriteLine("규칙 : 숫자는 3자리고, 입력은 한 자리씩 해주세요.");
			Console.WriteLine("숫자에는 0이 들어가지 않습니다!");
			Console.WriteLine("기회는 총 10번!");
			Console.WriteLine("");

			int[] numBB = new int[3]; // 랜덤 수
			int[] player = new int[3];
			int numCount = 3;
			int strike = 0;
			int ball = 0;
			Random rand = new Random();

			for (int i = 0; i < 3; i++)
			{
				numBB[i] = rand.Next(1, 10);
			}

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (i != j && numBB[i] == numBB[j])
					{
						numBB[j] = rand.Next(1, 10);
						j = 0;
					}
				}
			}

			for (int i = 0; i < 3; i++)
			{
				Console.Write($"{numBB[i]}");
			}
			Console.WriteLine("");


			while (numCount > 0)
			{
				for (int i = 0; i < 3; i++)
				{
					Console.Write($"{i + 1}번째 숫자를 입력해주세요 : ");
					player[i] = int.Parse(Console.ReadLine());
				}

				for (int i = 0; i < 3; i++)
				{
					Console.Write($"{player[i]} ");
				}

				// 스트라이크 판단
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						if (i == j && numBB[i] == player[j])
						{
							strike++;
						}
					}
				}

				// 볼 판단
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						if (i != j && numBB[i] == player[j])
						{
							ball++;
						}
					}
				}

				if (strike == 3)
				{
					Console.WriteLine($"\n-> 정답을 맞췄습니다!");
					break;
				}

				if (strike == 0 && ball == 0)
				{
					Console.WriteLine("\n[아웃! 모든 수가 틀렸어요!]");
				}
				else
				{
					Console.WriteLine($"\n[스트라이크 : {strike}, 볼 : {ball}]");
				}

				numCount--;
				if (numCount == 0)
				{
					Console.WriteLine("\n-> 기회를 모두 써버렸어요..");
				}

				Console.WriteLine($"남은 횟수 : {numCount}\n");

				strike = 0;
				ball = 0;
			}

			Console.Write("\n<<정답은 ");
			for (int i = 0; i < 3; i++)
			{
				Console.Write($"{numBB[i]}");
			}
			Console.Write("!!!>>\n");
		}
	}
}