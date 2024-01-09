namespace _13._Exception
{
	internal class Program
	{
		/****************************************************************
         * 예외처리 (Exception Handling)
         *
         * 프로그램 동작 도중 발생하는 의도하지 않은 상황을 처리하는 방법
         ****************************************************************/

		// <조건문을 통한 예외처리>
		// 프로그램이 중단될 수 있을만한 처리를 조건문을 통해 진행할 수 없도록 제한
		// 가장 좋은 예외처리 방법은 처음부터 예외가 발생할 수 없도록 설계하는 것

		static void Main1(string[] args)
		{
			int value1 = 10;
			int value2 = 0;

			// 만약 value2가 0인 경우 예외처리를 진행하지 않으면 프로그램이 중단됨
			// 아래의 조건문을 통해 프로그램이 중단되는 상황에 대한 예외처리를 진행
			// 조건 처리 방법이 가장 바람직하다.. ?
			if (value2 != 0)
			{
				Console.WriteLine($"{value1} / {value2} == {value1 / value2}입니다.");
			}
			else
			{
				Console.WriteLine("0으로 나눌 수 없습니다.");
			}
		}

		// <try catch 예외처리>
		// 예외가 발생할 수 있는 구문을 지정하고 진행중 예외가 발생할 경우 발생한 예외를 처리하는 구문을 작성
		// try : 예외발생에 대한 검사의 범위를 지정하는 블록
		// catch : 발생한 예외를 처리하는 블록

		static void Main2(string[] args)
		{
			try
			{
				// try 구문 수행중 처리할 수 없는 예외상황 발생시
				// catch 구문중 처리할 수 있는 예외처리 부분이 실행됨

				Console.Write("수를 입력하세요 : ");
				string input = Console.ReadLine();

				int value = int.Parse(input); // error 발생 가능성 1

				int[] array = new int[value]; // error 발생 가능성 2

				array[10] = 10; // error 발생 가능성 3

				Console.WriteLine($"입력하신 수는 : {value}");

			}
			/*catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("잘못된 문자를 입력했습니다.");
			}*/
			catch (FormatException ex) // 형변환 할 때 맞지 않았다
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("입력값이 정수로 변환이 불가한 경우 예외 발생");
			}
			catch (OverflowException ex) // 오버플로우
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("입력값으로 배열을 만들 수 없는 경우 예외 발생");
			}
			catch (IndexOutOfRangeException ex) // 배열의 크기 벗어났을 때
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("입력값이 10 이하인 경우 [10] 인덱스 접근이 불가하여 예외 발생");
			}
			catch (Exception ex) // 위에서 나열한 예외 사항 제외하고 모든 exception
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("모든 예외 상황을 확인하고 예외 발생시 처리");
			}
		}

		// <throw 예외 발생>
		// 의도적으로 예외를 발생시키는 방법
		// 프로그램에서 치명적일 수 있는 동작이 예상되는 경우 예외 처리를 유도하기 위해 진행
		static void Main3(string[] args)
		{
			try
			{
				int[] array = { 1, 3, 5, 7, 9 };
				int index = Array.IndexOf(array, 8);    // 값을 찾을 수 없는 경우 -1 반환

				if (index < 0)
					throw new InvalidOperationException(); // 내가 예외 발생시켜서 catch로 보냄

				array[index] = 0;
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("배열에서 원하는 값을 찾지 못함");
			}
		}

		// <스택 풀기>
		// 함수에서 예외가 발생한 경우 catch 문을 발견할 때까지 호출된 스택을 풀어냄
		static void Func3() { Console.Write("3전"); throw new Exception("스택풀기"); Console.Write("3후"); }
		static void Func2() { Console.Write("2전"); Func3(); Console.Write("2후"); }
		static void Func1() { Console.Write("1전"); Func2(); Console.Write("1후"); }

		static void Main(string[] args)
		{
			try
			{
				Func1(); // 1전 2전 3전 (스택풀어서 3후 2후 1후 실행X) catch 구문 실행 -> "스택풀기" 구문 출력
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

	}
}
