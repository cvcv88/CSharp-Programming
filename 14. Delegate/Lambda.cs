using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
	internal class Lambda
	{
		/*************************************************************************
		* 무명메서드와 람다식
		* 
		* 델리게이트 변수에 할당하기 위한 함수를 소스코드 구문에서 생성하여 전달
		* 전달하기 위한 함수가 간단하고 일회성으로 사용될 경우에 간단하게 작성
		*************************************************************************/

		static void Main()
		{
			Action<string> action;
			// <함수를 통한 할당>
			// 클래스에 정의된 함수를 직접 할당
			// 클래스의 멤버함수로 연결하기 위한 기능이 있을 경우 적합
			action = Message;

			// 일회용으로 잠시 쓰고 버리기 위한 함수를 멤버 함수 형태로 만들기에는 곤.란.
			// 이럴 때 필요한것이 무명메소드 -> 람다식

			// <무명메서드>
			// 함수를 통한 연결은 함수가 직접적으로 선언되어 있어야 사용 가능
			// 할당하기 위한 함수가 간단하고 자주 사용될수록 비효율적
			// 간단한 표현식을 통해 함수를 즉시 작성하여 전달하는 방법
			// 전달하기 위한 함수가 간단하고 일회성으로 사용될 경우에 적합
			action = delegate (string str) { Console.WriteLine(str); };
			// 소괄호 : 매개변수, 중괄호 : 함수의 내용
			action("메세지");


			// <람다식>
			// 와! 무명메소드 보다 더 간단하다!
			// 무명메서드의 간단한 표현식
			action = (str) => { Console.WriteLine(str); };
			// 괄호 매개변수, 람다식이라는 뜻? => 표시, 중괄호에 내용
			action = str => Console.WriteLine(str);
			// 매개변수도 하나, 조건식도 하나면 괄호, 중괄호 생략도 가능!!!
			// 프로그래머스 대문자와 소문자 글에 있는 그거!!!
		}

		void Message(string str)
		{
			Console.WriteLine(str);
		}

		bool Less1(int value)
		{
			return value < 1;
		}

		bool Less2(int value)
		{
			return value < 2;
		} // ㅋㅋㅋㅋ 웃긴 방법이다
	}
}
