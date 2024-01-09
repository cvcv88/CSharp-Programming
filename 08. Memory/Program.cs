namespace _08._Memory
{
	internal class Program
	{
		/* * * * * * *  
		 * 메모리 (Memory)
		 * 
		 * 프로그램을 처리하기 위해 필요한 정보를 저장하는 기억장치
         * 프로그램은 메모리에 저장한 정보를 토대로 명령들을 수행함
         * 용도별로 영역을 구분해서 사용.
		 * * * * * * */

		// 빠른 계산 (CPU) - 뇌
		// 저장 장치 (Memory) 

		/* * * * * * *  
		 * 메모리 구조
		 * 
		 * 프로그램은 효율적인 메모리 관리를 위해 메모리 영역을 구분
         * 데이터는 각 역할마다 저장되는 영역을 달리하여 접근범위, 생존범위 등을 관리
		 * * * * * * */

		/* <메모리 구조>
		   (0x0000...) +-------------+
		   낮은주소    | 코드 영역   | => 실행할 프로그램의 코드
					   +-------------+
					   | 데이터 영역 | => 정적변수
					   +-------------+
					   | 힙 영역     | => 클래스 인스턴스
					   +~~~~~~~~~~~~~+
					   |             |
					   +~~~~~~~~~~~~~+
		   높은주소    | 스택 영역   | => 지역변수, 매개변수
		   (0xFFFF...) +-------------+
		*/

		// 힙 영역과 스택 영역은 서로 유동적임.

		// <코드 영역>
		// 프로그램이 실행할 코드가 저장되는 영역
		// 데이터가 변경되지 않은 읽기 전용 데이터
		// 함수, for문, if문 같은 것들이 저장되어 있음.


		// <데이터 영역>
		// 정적변수(Static)가 저장되는 영역
		// 프로그램의 시작시 할당되며 종료시 삭제됨
		// 동작 도중에 늘어나거나 줄어들 수 있는 데이터들은 저장 안함.


		// <스택 영역>
		// 지역변수와 매개변수가 저장되는 영역
		// 함수의 호출시 할당되며 종료시 삭제됨
		// 함수의 시작부터 끝까지 존재.


		// <힙 영역>
		// 클래스 인스턴스가 저장되는 영역 (== 객체가 저장되는 영역.)
		// 인스턴스를 생성시 할당되며 더이상 사용하지 않을시 ^자동^으로 삭제됨 (- 가비지 컬렉터에 의해서.)
		// 인스턴스를 참조하고 있는 변수가 없을 때 더이상 사용하지 않는다고 판단
		// 더이상 사용하지 않는 인스턴스는 가비지 컬랙터가 특정 타이밍에 수거해감


		// <변수의 접근범위와 생존범위>
		/*
                     | 메모리영역    접근 범위       생존 범위
            ---------+---------------------------------------------------------
            정적변수 | 데이터영역    모든            프로그램 시작에서 끝까지
            ---------+---------------------------------------------------------
            지역변수 | 스택영역      블록 내부       블록 시작에서 끝까지
            매개변수 |				{ }
            ---------+---------------------------------------------------------
            (클래스) | 힙영역        참조가능한      인스턴스 생성부터
            인스턴스 |               모든 구역       더이상 사용하지 않을때까지
        */


		/* * * * * * *  
		 * 스택 영역
		 * 
		 * 함수호출스택을 이용하여 호출과 종료에 연관되는 데이터를 저장하는 영역
         * 프로그램은 스택구조를 통해 함수에서 사용한 데이터들을 효율적으로 관리함
		 * * * * * * */

		// <함수호출스택>
		void Stack2(int a)  // 매개변수 a
		{
			a = 3;
			int b = 1;      // 지역변수 b
		}
		void Stack1(int a)  // 매개변수 a
		{
			a = 2;
			int b = 10;     // 지역변수 b
			Stack2(a);
		}

		void Main1()
		{
			int a = 1;      // 지역변수 : 블록 안에서 생성, 블록 끝에서 소멸
			int b = 20;
			Stack1(a);
		}

		/*
                           +-----------+                +-----------+                +-----------+
                           |           |                |           |                |           |
                           |           |                |           |                +-----------+
                           |           |                |           |                | Stack2()  |
                           |           |                |           |                | a = 3     |
                           |           |                +-----------+                +-----------+
                           |           |                | Stack1()  |                | Stack1()  |
                           |           |                | a = 2     |                | a = 2     |
                           +-----------+                +-----------+                +-----------+
                           | Main1()   |                | Main1()   |                | Main1()   |
                           | a = 1     |                | a = 1     |                | a = 1     |
            Main1 호출 ->  +-----------+ Stack1 호출 -> +-----------+ Stack2 호출 -> +-----------+

                           +-----------+                +-----------+                +-----------+
                           |           |                |           |                |           |
                           |           |                |           |                |           |
                           |           |                |           |                |           |
                           |           |                |           |                |           |
                           +-----------+                |           |                |           |
                           | Stack1()  |                |           |                |           |
                           | a = 2     |                |           |                |           |
                           +-----------+                +-----------+                |           |
                           | Main1()   |                | Main1()   |                |           |
                           | a = 1     |                | a = 1     |                |           |
            Stack2 종료 -> +-----------+ Stack1 종료 -> +-----------+ Main1 종료 ->  +-----------+
        */
		// 상자 쌓듯이 작동, LIFO 후입 선출 Last In First Out





		/* * * * * * *  
		 * 힙 영역
		 * 
		 * 클래스 인스턴스가 보관하는 영역
         * 프로그램은 가비지 콜렉터를 통해 더이상 사용하지 않는 인스턴스를 수거함
		 * * * * * * */

		// <가비지 콜렉터>
		// 1. 가비지 컬렉터 대상 : 가리키고 있는 변수가 없는 객체
		// 2. 가비지 컬렉터 알고리즘 : mark & sweep
		// 3. 관리 기법 : 세대관리, Unity 점진적 ..

		class HeapClass { }

		void Main2()
		{
			// 함수 시작시
			// 지역변수 local 이 스택 영역에 저장됨

			HeapClass local;              // 함수 시작시 이미 메모리에 할당되어 있음
			local = new HeapClass();      // 인스턴스를 힙영역에 생성하고 주소값을 local에 보관
										  // 변수 local은 스택영역에, 인스턴스 new HeapClass() 는 힙영역에

			// 함수 종료시
			// 지역변수 local 이 함수 종료와 함께 소멸됨
			// 인스턴스 new HeapClass() 는 함수 종료와 함께 더이상 사용되지 않음 (더이상 참조하는 변수가 없음)
			// 인스턴스 new HeapClass() 는 가비지가 되어 가비지 컬렉터가 동작할 때 소멸됨
		}





		/* * * * * * *  
		 * 데이터 영역
		 * 
		 * 정적변수(<-> 동적변수, dyinamic)를 저장하는 영역
         * 프로그램은 시작시 데이터 영역을 생성하며 종료시 데이터 영역을 해제함
		 * * * * * * */

		// <정적 (static)>
		// 프로그램의 시작과 함께 할당, 프로그램 종료시에 소멸, 프로그램이 동작하는 동안 항상 고정된 위치에 존재
		// 정적변수 : 프로그램 전역에서 접근 가능한 변수, 클래스의 이름을 통해 접근 가능
		// 정적함수 : 인스턴스 없이도 접근 가능한 함수, 클래스의 이름을 통해 접근 가능
		// 정적클래스 : 인스턴스 없이도 접근 가능한 클래스, 정적변수와 정적함수만을 포함 가능


		class A
		{
			public static int a; // 어디서든 접근 가능하다.
		}


		class Player
		{
			public static int value; // 정적변수 value
		}
		static void Main1(string[] args)
		{
			Player.value = 10;  // 어느 영역에서나 클래스의 이름을 통해 접근할 수 있다.
		}


		public class StaticTest
		{
			public static int value;
			public static void Test()
			{

			}
		}
		static void Main2(string[] args)
		{
			StaticTest.value = 10;
			StaticTest.Test();
		}


		public static class StaticClass
		{
			public static int value;
			// public int x; // error
			public static void Test()
			{

			}
		}



		// static 에서 static이 아닌 것은 못씀. static 클래스는 static만 가질 수 있다.
		// static이 아닌 곳에서 static은 쓸 수 있음.
		// 왜?
		// static은 데이터 영역(시작부터 끝까지)에 있기 때문에,
		// 동작 도중에 생기는 힙, 스택 영역의 것들은 사용 불가.

		class StaticClass1
		{
			public static int staticValue;
			public int nonStaticValue;

			public static void StaticFunc()
			{
				Console.WriteLine(staticValue);                     // 정적함수에서 정적변수를 사용
																	// Console.WriteLine(nonStaticValue);               // error : 정적함수에서 멤버변수를 사용할 수 없음

				StaticClass1 staticClass1 = new StaticClass1();
				Console.WriteLine(staticClass1.nonStaticValue);     // 정적함수에서 생성한 인스턴스는 사용할 수 있음
			}

			public void NonStaticFunc()
			{
				Console.WriteLine(staticValue);
				Console.WriteLine(nonStaticValue);
			}
		}

		static class StaticClass2
		{
			// public int nonStaticValue;       // error : 정적클래스에서 멤버변수를 포함할 수 없음
			// public void NonStaticFunc() { }  // error : 정적클래스에서 멤버함수를 포함할 수 없음

			public static int staticValue;
			public static void StaticFunc() { }
		}

		void Main3()
		{
			StaticClass1.staticValue = 10;                  // 정적변수는 전역적으로 접근 가능
			StaticClass1.StaticFunc();                      // 정적함수는 전역적으로 접근 가능
															// StaticClass.nonStaticInt = 10;               // error : 맴버변수는 인스턴스가 있어야 사용가능
															// StaticClass.NonStaticFunc();                 // error : 맴버함수는 인스턴스가 있어야 사용가능

			StaticClass1 instance = new StaticClass1();
			instance.nonStaticValue = 20;                   // 맴버변수는 인스턴스가 각자 가지고 있으며 인스턴스를 통해 접근
			instance.NonStaticFunc();                       // 맴버함수는 인스턴스가 각자 가지고 있으며 인스턴스를 통해 접근
															// instance.staticInt = 20;                     // error : 정적변수는 인스턴스가 아닌 클래스이름을 통해서 접근
															//instance.StaticFunc();                       // error : 정적함수는 인스턴스가 아닌 클래스이름을 통해서 접근

			// StaticClass2 instance = new StaticClass2();  // error : 정적클래스는 인스턴스를 만들 수 없음
			StaticClass2.staticValue = 30;
			StaticClass2.StaticFunc();
		}

		static void Main3(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}