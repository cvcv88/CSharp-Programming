namespace _03._Conditional
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* * * * * * *  
			 * 조건문(Conditional)
			 * 
			 * 조건에 따라 실행이 달라지게 할 때 사용하는 문장
			 * * * * * * */

			/* * * * * * *  
			 * if 조건문
			 * 
			 * 조건식의 true, false에 따라 실행할 블록을 결정하는 조건문
			 * * * * * * */

			// <if 조건문 기본>
			//if (/*조건식*/)
			//{

			//}
			//else
			//{

			//}

			int playerHp = 100;
			int monsterAtk = 20;
			if (playerHp > monsterAtk)
			{
				// 플레이어 체력이 몬스터의 공격력보다 크다면
				// 조건식의 결과가 true 라면
				Console.WriteLine("캐릭터가 아파한다..\n");
				playerHp -= monsterAtk;
			}
			else
			{
				// 플레이어 체력이 몬스터의 공격력보다 작다면
				// 조건식의 결과가 false 라면
				Console.WriteLine("캐릭터가 사망했다..\n");
				playerHp = 0;
			}

			bool isJumpPressd = true;
			bool isGround = true;
			if (isJumpPressd && isGround)
			{
				Console.WriteLine("쩜~~프\n");
			}
			else
			{
				// 어차피 아무것도 안하면 else는 생략도 가능.
				// else는 필수가 아니고 선택사항.
				Console.WriteLine("가만히 있는 중..\n");
			}

			string input = "바위"; // 가~위~바~위~보!
			if (input == "바위")
			{
				Console.WriteLine("바위를 냈다!\n");
			}
			else if (input == "가위")
			{
				Console.WriteLine("가위를 냈다!\n");
			}
			else if (input == "보")
			{
				Console.WriteLine("보를 냈다!\n");
			}
			else
			{
				Console.WriteLine("잘못된 입력\n");
			}


			int score = 99; // ~60 F, 61~70 D, 71~80 C, 81~90 B, 91~100 A)
			if (score <= 60)
			{
				Console.WriteLine("이 학생은 F일세\n");
			}
			else if (61 <= score && score <= 70)
			{   // 61 <= score 은 이미 이전의 if에서 걸러졌기때문에 또 쓸 필요없다!
				Console.WriteLine("이 학생은 D일세\n");
			}
			else if (score <= 80)
			{
				Console.WriteLine("이 학생은 C일세\n");
			}
			else if (score <= 90)
			{
				Console.WriteLine("이 학생은 B일세\n");
			}
			else if (score <= 100)
			{
				Console.WriteLine("이 학생은 A일세\n");
			}
			// 반대 상황이었을 때 조심하기

			/* * * * * * *  
			 * switch 조건문
			 * 
			 * 조건값에 따라 실행할 시작지점을 결정하는 조건문
			 * * * * * * */

			// <switch 조건문 기본>
			//switch (/*조건값*/)
			//{

			//}

			char c = 'E';
			switch (c)  // 조건값 지정
			{
				case 'A':
					Console.WriteLine("A!\n");
					break;
				case 'B':
					Console.WriteLine("B!\n");
					break;
				case 'C':
					Console.WriteLine("C!\n");
					break;
				default:
					Console.WriteLine("너 대체 뭐야!\n");
					break;
			}

			char d = 'A';
			if (d == 'A')
			{
				Console.WriteLine("A!\n");
			}
			else if (d == 'B')
			{
				Console.WriteLine("B!\n");
			}
			else if (d == 'C')
			{
				Console.WriteLine("C!\n");
			}

			// 조건값에 따라 동일한 실행이 필요한 경우 묶어서 사용 가능
			char key = 'w';
			switch (key)
			{
				case 'w':
				case 'W':
				case 'ㅈ':
					Console.WriteLine("위쪽으로 이동");
					break;
				case 'a':
				case 'A':
				case 'ㅁ':
					Console.WriteLine("왼쪽으로 이동");
					break;
				case 's':
				case 'S':
				case 'ㄴ':
					Console.WriteLine("아래쪽으로 이동");
					break;
				case 'd':
				case 'D':
				case 'ㅇ':
					Console.WriteLine("오른쪽으로 이동");
					break;
				default:
					Console.WriteLine("이동하지 않음");
					break;
			}


			/* * * * * * *  
			 * 삼항연산자
			 * 
			 * 간단한 조건문을 빠르게 작성
			 * * * * * * */

			int left = 5;
			int right = 9;

			int bigger;

			if (left > right)
			{
				bigger = left;
			}
			else
			{
				bigger = right;
			}
			// 으아 너무 길어~

			bigger = left > right ? left : right;
			// 변수 = 조건식 ? 맞으면 실행 : 틀리면 실행;

		}
	}
}