using System.Numerics;
using System.Reflection;

namespace _05._Function
{
	internal class Program
	{
		/* * * * * * *  
		 * 함수 (Function)
		 * 
		 * 미리 정해진 동작을 수행하는 코드 묶음
		 * 어떤 처리를 미리 함수로 만들어 두면 다시 반복적으로 사용 가능
		 * main 보다 뒤에 있어도 상관없다.
		 * * * * * * */

		// <함수 구성>
		// 일련의 코드를 하나의 이름 아래에 묶음
		// 반환형 함수이름(매개변수목록) { 함수내용 }
		// = 출력 이름(입력들) { 동작 }
		// 함수 이름은 대문자로 시작하고 변수 이름은 소문자로 시작하자.
		static int Plus(int left, int right)
		{
			Console.WriteLine($"Input : {left}, {right}");
			int result = left + right;
			Console.WriteLine($"Output : {result}");
			return result;
		}

		// <함수 사용>
		// 함수로 구성해둔 코드를 이름을 불러 사용함
		static void Main1(string[] args)
		{
			// 함수를 사용하지 않는 경우
			Console.WriteLine($"Input : {1}, {2}");
			int result1 = 1 + 2;
			Console.WriteLine($"Output : {result1}");
			int value1 = result1;

			Console.WriteLine($"Input : {3}, {4}");
			int result2 = 3 + 4;
			Console.WriteLine($"Output : {result2}");
			int value2 = result2;

			Console.WriteLine($"Input : {5}, {6}");
			int result3 = 5 + 6;
			Console.WriteLine($"Output : {result3}");
			int value3 = result3;

			// 함수를 사용하는 경우
			int value4 = Plus(1, 2);
			int value5 = Plus(3, 4);
			int value6 = Plus(5, 6);

			Plus(4, 5);
			Plus(123, 789);
			Plus(1111, 9999);
		}



		// <반환형 (Return Type)>
		// 함수의 결과(출력) 데이터의 자료형
		// 함수가 끝나기 전까지 반드시 return으로 반환형에 맞는 데이터를 출력해야함
		// 함수 진행 중 return을 만나는 경우 그 즉시 결과 데이터를 반환하고 함수가 종료됨
		// 함수의 결과(출력)이 없는 경우 반환형은 void이며 return을 생략 가능

		static int Return10()
		{
			Console.WriteLine("도달하는 코드\n");

			return 10;

			// return 이후 코드는 진행되지 않음
			Console.WriteLine("도달하지 못하는 코드\n");
		}
		static void PrintProfile(string name, string phone)
		{
			if (name == "")
			{
				Console.WriteLine("이름을 입력해주세요.");
				return;     // void 반환형에서 return을 진행하는 경우 함수 종료의 역할을 함
			}

			Console.WriteLine($"이름 : {name}, Phone : {phone}");
		}

		static void Main2(string[] args)
		{
			int ret = Return10();   // Return10 함수에서 반환된 10이 결과로 나옴

			PrintProfile("", "010-1234-5678");          // void 반환형의 함수는 실행에 의미
			PrintProfile("홍길동", "010-1111-2222");
		}



		// <매개변수 (Parameter)>
		// 함수에 추가(입력)할 데이터의 자료형과 변수명
		// 같은 함수에서도 매개변수 입력이 다름에 따라 다른 처리가 가능
		static int Minus(int left, int right)
		{
			// 함수의 입력으로 넣어준 매개변수 left, right 에 따라 함수가 동작
			return left - right;
		}

		static void Main3(string[] args)
		{
			int value1 = Minus(20, 10);     // 매개변수 20, 10이 들어간 Minus 함수의 반환은 10
			int value2 = Minus(30, 10);     // 매개변수 30, 10이 들어간 Minus 함수의 반환은 20
		}



		// <함수 호출 순서>
		// 함수는 호출되었을 때 해당 함수블록으로 제어가 전송되며
		// 완료되었을 때 원위치로 제어가 전송됨
		static void Func2()
		{               // 1 
						// 2
		}               // 3

		static void Func1()
		{               // 4
			Func2();    // 5
		}               // 6

		static void Main4()
		{               // 7
			Func1();    // 8
		}               // 9
						// 함수 호출 순서 : 7 -> 8 -> 4 -> 5 -> 1 -> 2 -> 3 -> 6 -> 9


		static int TripleShot()
		{
			int damage = 0;
			for (int i = 0; i < 3; i++)
			{
				damage += Attack();
			}
			return damage;
		}
		static int Attack()
		{
			Console.WriteLine("공격이닷~");
			return 10;
		}

		static void Main4(string[] args)
		{
			int totalDamage = TripleShot();
			Console.WriteLine($"피해 : {totalDamage}");
		}



		// <함수 오버로딩>
		// 같은 이름의 함수를 매개변수를 달리하여 다른 함수로 재정의하는 기술
		// 같은 이름의 함수를 호출하여도 매개변수의 자료형에 따라 함수를 달리 호출할 수 있음

		static int Multi(int left, int right) { return left * right; }
		static float Multi(float left, float right) { return left * right; }
		static double Multi(double left, double right) { return left * right; }

		static void Main(string[] args)
		{
			/*int result1 = Multi(5, 3);     // Multi(int, int)가 호출됨
			float result2 = Multi(5.1f, 3.3f);     // Multi(float, float)가 호출됨
			double result3 = Multi(5.1, 3.3);     // Multi(double, double)가 호출됨*/

			int[] sides = new int[] { 2, 4, 6 };
			int max = sides.Max();
		}
	}
}