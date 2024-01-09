namespace _01._Variable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* * * * * * *  
			 * 자료형(Data Type)
			 * 
			 * 자료(데이터)의 형태를 지정
			 * 데이터가 메모리에 저장되는 형태와 처리되는 방식을 명시하는 역할
			 * 0과 1(bit)만으로 구성된 컴퓨터에게 여러 형태의 자료를 저장하기 위함
			 * 메모리의 기본 단위 : 1byte(8bit)
			 * * * * * * */

			/*
			// <자료형 종류>
			// 자료형 이름		자료형 형태			메모리 크기		표현 범위
			// 
			// - 논리형 -
			// bool				논리 자료형			1 byte(8bit)	true(1, 0이 아닌 수), false(0)
			// 
			// - 정수형(소수점X) -
			// byte(sbyte : -128 ~ 127)				1 byte			0 ~ 255
			// 
			// short(그냥보기만)	부호 있는 정수형		2 byte			-32,768 ~ +32,767
			// int              부호 있는 정수형		4 byte          -21억 ~ 21억
			// long(그냥보기만)	부호 있는 정수형		8 byte			-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
			//
			// signed 부호O, unsigned 부호X
			// uint				부호 있는 정수형		4 byte			0 ~ 42억
			// 
			// - 실수형(소수점O) -                                                                     
			// float            부동소수점 실수      4 byte           3.4e-38  ~ 3.4e+38   =>  약 소수점 7자리
			// double           부동소수점 실수      8 byte           1.7e-308 ~ 1.7e+308  =>  약 소수점 15자리
			//
			// - 문자형 - 
			// char(한글자)		유니코드 문자형      2 byte           'a', 'b', '한', ... 따옴표 ''
			// string(여러글자)	유니코드 문자열        X             "abcde", "안녕", ... 쌍따옴표 ""
			// 11 : 정수, 11.2 : 실수, '1' : char, "1" : string
			// 
			// 아스키코드 : 영어 기반 문자-숫자 대응 부호, 아스키 코드 문자형-1byte
			// 유니코드 : 영어 이외의 다국어까지 지원하는 문자-숫자 대응 부호, 유니코드 문자형-2byte


			// <자료형 종류>
			// 자료형 이름		자료형 형태			메모리 크기		표현 범위
			// 
			// - 논리형 -
			// bool				논리 자료형			1 byte(8bit)	true(1), false(0)
			// 
			// - 정수형 -
			// byte				부호 있는 정수형		1 byte			0 ~ 255
			// 
			// int              부호 있는 정수형		4 byte          -21억 ~ 21억
			// uint				부호 있는 정수형		4 byte			0 ~ 42억
			// 
			// - 실수형 -                                                                     
			// float            부동소수점 실수형		4 byte           3.4e-38  ~ 3.4e+38   =>  약 소수점 7자리
			// double           부동소수점 실수형		8 byte           1.7e-308 ~ 1.7e+308  =>  약 소수점 15자리
			//
			// - 문자형 - 
			// char				유니코드 문자형      2 byte           'a', 'b', '한', ...
			// string			유니코드 문자열        X             "abcde", "안녕", ...
			*/

			/* * * * * * *  
			 * 변수(variable)
			 * 
			 * 데이터를 저장하기 위해 프로그램에 의해 이름을 할당받은 메모리 공간
             * 데이터를 저장할 수 있는 메모리 공간을 의미하며, 저장된 값은 변경 가능
			 * * * * * * */

			// <변수 선언 및 초기화>
			// 자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수 선언
			// 선언한 변수에 값을 처음 할당하는 과정을 초기화라고 함
			// 변수 선언과 초기화 과정을 동시에 진행할 수 있음

			/*
			int level = 1;
			Console.WriteLine("Level : " + level);
			level = 10; // 초기화
			Console.WriteLine("Level : " + level);
			level = 20; // 대입
			Console.WriteLine("Level : " + level);
			level = 30; // 대입
			Console.WriteLine("Level : " + level + "\n");
			// level = true;	// error : int형 변수에 true 넣으면 자료형과 값이 맞지 않아서 오류가 뜬다.

			int iValue = 10;					// int 자료형의 이름이 intValue인 변수에 10의 데이터를 초기화
			float fValue;                       // float 자료형의 이름이 floatValue인 변수를 선언하지만 값을 초기화하지 않음
												// int iValue = 20;					// error : 같은 이름의 변수는 사용 불가
												// Console.WriteLine(floatValue);	// error : 선언한 변수에 값을 초기화하기 전까지 사용 불가
			// <변수에 데이터 저장>
			// =(대입연산자) 좌측에 변수를 배치
			iValue = 5;                         // iValue 변수에 5의 데이터 저장
			fValue = 1.2f;                      // fValue 변수에 1.2f 데이터를 초기화
												// fValue = 1.2;					// 소수 뒤에 f 붙이지 않으면 자동 Double로 처리!!

			// <변수의 데이터 불러오기>
			int rValue = 20;
			int lValue = rValue;

			Console.WriteLine("iValue에 저장한 값은 iValue 입니다.");

			Console.WriteLine(rValue);
			Console.WriteLine($"{rValue}!!");
			Console.WriteLine($"rValue 변수에 보관된 데이터는 {rValue}");
			Console.WriteLine($"iValue 변수에 보관된 데이터는 {iValue}");

			
			float num = 10.23456f;
			Console.WriteLine($"당신의 레벨은 {num} 입니다.");
			Console.WriteLine($"당신의 레벨은 {num:f3} 입니다.");
			Console.WriteLine($"당신의 레벨은 {num,-10:f3} 입니다.");
			Console.WriteLine($"당신의 레벨은 {num,+10:f3} 입니다.");
			*/



			/* * * * * * *  
			 * 상수(Constant)
			 * 
			 * 프로그램이 실행되는 동안 변경할 수 없는 데이터
             * 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있을 경우 사용
             * 저장된 값은 프로그램 종료시까지 변경 불가능
			 * * * * * * */

			/*
			// <상수 선언 및 초기화>
			// 상수는 대문자로 이름 짓기.
			// 변수 선언 앞에 const 키워드를 추가하여 상수 선언
			const int MAX = 200;        // MAX 상수 변수를 선언하고 초기화
			Console.WriteLine($"MAX 상수에 보관된 데이터는 {MAX} 입니다.");
			// 상수를 사용할 때 안되는 것 두 가지
			// const int MIN;           // error : 상수는 초기화 없이 사용불가
			// MAX = 20                 // error : 상수의 데이터 변경 불가
			*/


			/* * * * * * *  
			 * 배열(Array)
			 * 
			 * 동일한 자료형의 요소들로 구성된 데이터 집합
             * 인덱스를 통하여 개개의 ^배열요소(Element)^에 접근할 수 있음
             * 배열의 처음 요소의 ^인덱스^는 0부터 시작함
			 * * * * * * */

			/*
			string student1 = "010-1234-1234";
			string student2 = "010-1234-1234";
			string student3 = "010-1234-1234";

			string[] student = { "010-1234-1234", "010-1111-1111", "010-1234-5678" };

			int[] exam;			// int 배열 선언
			exam = new int[10]; // int 데이터를 10개 가지는 배열 생성

			exam[0] = 99;		// 1차원 배열의 0번째 배열요소에 접근
			exam[1] = 80;
			exam[2] = 85;

			float[] fArray = { 1.1f, 2.3f, 3.1f, 4.5f };
			// 1차원 배열의 선언과 초기화, 배열의 크기는 초기화한 갯수만큼 자동으로 생성

			int[] array;
			array = new int[10];
			array[0] = 20;


			// <다차원 배열>
			// 다차원 배열의 선언은 자료형뒤에 []괄호를 추가하며, 추가하는 차원수만큼 ','를 추가

			int[,] iMatrix = new int[5, 10];		// 2차원 배열 선언
			int[,,] iCube = new int[3, 3, 3];		// 3차원 배열 선언 3x3x3 = 18개
			iMatrix[2, 2] = 10;						// 2차원 배열의 2x2번째 배열요소에 접근
			float[,] fMatrix = { { 1.1f, 2.2f }, { 3.3f, 4.4f } };
			// 2차원 배열의 선언과 초기화, 배열의 크기는 초기화한 갯수만큼 자동으로 생성
			*/


			/* * * * * * *  
			 * 형변환(Casting)
			 * 
			 * 데이터를 선언한 자료형에 맞는 형태로 변환하는 작업
             * 다른 자료형의 데이터를 저장하기 위해선 형변환 과정을 거쳐야하며,
             * 이 과정에서 보관할 수 없는 데이터는 버려짐
			 * * * * * * */

			/* int level = 3;
			string name = "gamja";
			// level = "gamja";
			// name = 3;

			// int hp = "100";


			// <명시적 형변환 - 수동> 
			// 데이터에 손실이 있을 때는 명시적 형변환을 반드시 해야 한다.
			// 변환할 데이터의 앞에 변환할 자료형을 괄호안에 넣어 형변환 진행
			int intValue = (int)1.2;    // 1.2를 int로 변환하는 과정 중 보관할 수 없는 소수점이 버려짐
			float floValue = (float)123.45678901234d;	// 담을 수 없는 부분은 없애고 float 자리수로 바뀜..
			// int intValue = 1.2f;		// error : 명시적 형변환 없이 변환 불가 

			// <묵시적 형변환 - 자동>
			// 변수에 데이터를 넣는 과정에서 자료형이 더 큰범위를 표현하는 경우 자동으로 형변환을 진행
			float floatValue = 3;               // 부동소수점형 변수에 정수형 데이터를 넣을 경우 자동형변환 가능
			double doubleValue = 1.2f;          // double은 float를 포함하는 큰 범위이니 자동형변환 가능
			doubleValue = (double)floatValue;   // 일반적으로 변수의 형변환 같은 경우 자동형변환이 가능하다 하더라도 형변환을 적어줌

			double ddd1 = (double)123.456f;     // == double ddd1 = 123.456f;
			double ddd2 = (double)123;          // == double ddd2 = 123;
												// double은 float, int를 포함하는 더 큰 범위이니 자동형변환 가능
			*/

			// <문자 형변환과 아스키코드 & 유니코드>
			// 아스키코드 : 이진법을 사용하는 컴퓨터에서 문자를 표현하기 위해 정해둔 문자와 숫자의 매칭표
			// 유니코드 : 영어만 표현이 가능했던 아스키코드에서 전세계의 모든 문자를 다루도록 설계한 매칭표

			/*
			Console.WriteLine($"유니코드 65는 {(char)65} 로 표현합니다.");
			Console.WriteLine($"문자 'a'는 {(int)'a'} 로 처리합니다.");
			
			char key = (char)65;    // A
			int value = (int)'a';   // 97
			
			// int hp = (int)"100";	// "100" 문자열은 단순히 명시적으로는 형변환 불가능
			*/


			// <문자열 형변환>
			// 문자열은 단순형변환이 불가
			// 각 자료형의 Parse, TryParse를 이용하여 문자열에서 자료형으로 변환
			// 각 자료형에서 ToString을 이용하여 자료형에서 문자열로 변환

			/*
			int value = int.Parse("142");               // int.Parse를 통해 string 자료형을 int로 변환
														// int value = (int)"142";                  // error : 문자열 자료를 정수형 자료형으로 단순형변환은 불가능
														// int value = int.Parse("abc");            // error : 변환할 수 없는 문자열 자료를 정수형으로 변환하려 시도하는 경우 예외 발생
			
			float percent = float.Parse("0.2"); 
			
			// TryParse : 변환이 가능하면 변환, 그렇지 않으면 변환하지 않음.
			int num = 0;
			bool fail = int.TryParse("abc", out num);         // 변환이 불가한 문자열이므로, fail은 false, value는 0이 결과로 나옴
			bool successs = int.TryParse("123", out num);     // 변환이 가능한 문자열이므로, success는 true, value는 변환 결과가 나옴
			Console.WriteLine(num);
			
			// string hundred = (string)100; // 불가능
			string hundred = 100.ToString();
			string aaa = 10.2f.ToString();

			string valueToString = value.ToString();	

			*/

		}
	}
}