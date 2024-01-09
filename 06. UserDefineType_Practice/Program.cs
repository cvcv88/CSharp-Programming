/*
 * 가위, 바위, 보 게임을 함수, 열거형, 구조체를 이용하여 체계화 시키자
 * 플레이어한테 가위, 바위, 보 중에서 하나를 입력받도록 함
 * 컴퓨터는 랜덤으로 가위, 바위, 보 중에서 하나를 선택하도록 함
 * 가위, 바위, 보의 승패를 계산해서 이긴측에 승수를 1 올려주도록 함
 * 어느 한쪽이라도 3승을 먼저 한 경우 ~~~가 승리 했습니다.
 * 
 * 조건1. Main 함수의 길이는 20줄로 제한 => 반복적으로 사용하는 기능을 함수로 구성
 * 조건2. 가위,바위,보 string 허용 X => 가위, 바위, 보를 열거형 관리 (코드가독성)
 * 조건3. 플레이어 입력 ReadLine() X => ReadKey() 로 진행 (반환형이 ConsoleKeyInfo)
 */


using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _06._UserDefineType_Practice
{
	internal class Program
	{
		enum Rsp { Scissors = 1, Rock, Paper }
		static Rsp Input()
		{
			Console.WriteLine("\n가위(F1), 바위(F2), 보(F3) 중에 한 가지를 입력해주세요!");
			ConsoleKeyInfo input = Console.ReadKey();
			Rsp rsp = new Rsp();

			if (input.Key == ConsoleKey.F1)
			{
				rsp = Rsp.Scissors;
				return rsp;
			}
			else if (input.Key == ConsoleKey.F2)
			{
				rsp = Rsp.Rock;
				return rsp;
			}
			else
			{
				rsp = Rsp.Paper;
				return rsp;
			}
		}

		static int Judge(Rsp myRsp, Rsp comRsp)
		{
			if (myRsp.Equals(comRsp))
			{
				Console.WriteLine("비겼습니다");
				return 0;
			}
			else if (myRsp.Equals(Rsp.Scissors) && comRsp.Equals(Rsp.Paper) ||
					myRsp.Equals(Rsp.Rock) && comRsp.Equals(Rsp.Scissors) ||
					myRsp.Equals(Rsp.Paper) && comRsp.Equals(Rsp.Rock))
			{
				Console.WriteLine("당신이 이겼습니다");
				return 1;
			}
			else
			{
				Console.WriteLine("당신이 졌습니다.");
				return 2;
			}
		}


		struct JudgeRsp
		{
			public int cWin;
			public int mWin;
			public int result;
			public string JPrint(int result)
			{
				if (result == 1)
				{
					mWin++;
				}
				else if (result == 2)
				{
					cWin++;
				}
				return $"컴퓨터의 승리 {cWin}회, 나의 승리 {mWin}회";
			}
		}

		static Rsp GetRandomRsp()
		{
			var values = System.Enum.GetValues(enumType: typeof(Rsp));
			return (Rsp)values.GetValue(new Random().Next(0, values.Length));
		}

		/*static int winPrint(int result, int cWin, int mWin)
		{
			if (result == 0)
			{
				Console.WriteLine($"컴퓨터의 승리 {cWin}회, 나의 승리 {mWin}회");
			}
			else if (result == 1)
			{
				mWin++;
				Console.WriteLine($"컴퓨터의 승리 {cWin}회, 나의 승리 {mWin}회");
			}
			else
			{
				cWin++;
				Console.WriteLine($"컴퓨터의 승리 {cWin}회, 나의 승리 {mWin}회");
			}
			return result;
		}*/
		static void Main(string[] args)
		{
			JudgeRsp jR = new JudgeRsp();
			while (jR.cWin < 3 && jR.mWin < 3)
			{
				Rsp comRsp = GetRandomRsp();
				Rsp myRsp = Input();
				Console.WriteLine($"컴퓨터 : {comRsp} vs 나 : {myRsp}");
				int result = Judge(myRsp, comRsp);
				Console.WriteLine(jR.JPrint(result));
			}
		}
	}
}