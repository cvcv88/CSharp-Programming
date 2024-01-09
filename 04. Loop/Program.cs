namespace _04._Loop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* * * * * * *  
			 * 반복문 (Iteration)
			 * 
			 * 블록을 반복적으로 실행하는 문장
			 * * * * * * */



			/* * * * * * *  
			 * while 반복문
			 * 
			 * 조건식의 true, false에 따라 블록을 반복하는 반복문
			 * * * * * * */

			int money = 1200;
			while (money > 0)
			{
				Console.WriteLine("지갑에서 100원 동전을 꺼내자.");
				money -= 100;
				Console.WriteLine($"지갑에 남은 돈은 {money}원이야..\n");
			}


			/* * * * * * *  
			 * do while 반복문
			 * 
			 * 블록을 한번 실행 후 조건식의 true, false에 따라 블록을 반복하는 반복문
			 * * * * * * */

			int input;
			do
			{
				Console.Write("1에서 9사이의 수를 입력하세요!!!!! \n->");
				string text = Console.ReadLine();
				input = int.Parse(text);
			} while (input < 1 || 9 < input);

			Console.WriteLine("");





			/* * * * * * *  
			 * for 반복문
			 * 
			 * 초기화, 조건식, 증감연산 으로 구성된 반복문
			 * * * * * * */

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine($"for문 {i + 1}번 반복하는 중~");
			}
			Console.WriteLine("");

			// 순서
			// 1. 초기화
			// 2. 조건식
			// 3. for문 아래 내용
			// 4. 증감연산
			// 횟수를 제어, 확인하고 싶을 때 사용하는 것이 적합하다!

			/* * * * * * *  
			 * foreach 반복문
			 * 
			 * 반복가능한 데이터집합의 처음부터 끝까지 반복
			 * * * * * * */

			int[] intArray = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
			foreach (int element in intArray)
			{
				Console.WriteLine($"foreach 반복문의 현재 요소 : {element}");
			}
			Console.WriteLine("");




			/* * * * * * *  
			 * 제어문
			 * 
			 * 프로그램의 순차적인 실행 중 다른 문으로 제어를 전송
			 * * * * * * */

			/* * * * * * *  
			 * break 문
			 * 
			 * 가장 가까운 반복문을 종료
			 * * * * * * */

			int num = 35;
			for (int i = 2; i < num; i++)
			{
				if (num % i == 0)
				{
					Console.WriteLine($"{num}을 나눌 수 있는 가장 작은 수는 {i} 입니다.");
					break;
				}
			}
			Console.WriteLine("");



			/* * * * * * *  
			 * continue 문
			 * 
			 * 가장 가까운 반복문의 새 반복을 시작
			 * * * * * * */

			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
					continue;
				if (i % 3 == 0)
					continue;

				Console.WriteLine($"{i}은 2의 배수와 3의 배수가 아닙니다.");
			}

		}
	}
}