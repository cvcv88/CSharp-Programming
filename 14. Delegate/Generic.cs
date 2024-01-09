using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
	internal class Generic
	{
		/**************************************************************************
         * 일반화 델리게이트
         * 
         * 개발과정에서 많이 사용되는 델리게이트의 경우 일반화된 델리게이트를 사용
         **************************************************************************/

		// <Func 델리게이트>
		// 반환형과 매개변수를 지정한 델리게이트
		// Func<매개변수1, 매개변수2, ..., 반환형>
		// 마지막이 무조건 반환형
		// 반환형 void는 Func 델리게이트 사용 불가 Action 써야함

		int Plus(int left, int right) { return left + right; }
		int Minus(int left, int right) { return left - right; }

		float AAA(int left, double right) { return 0f; }
		void Main()
		{
			Func<int, int, int> func;
			func = Plus;
			func = Minus;

			Func<int, double, float> func2;
			func2 = AAA;
		}



		// <Action 델리게이트>
		// 반환형이 void 이며 매개변수를 지정한 델리게이트
		// Action<매개변수1, 매개변수2, ...>

		// void는 엄밀히말하면 자료형은 아니기때문에 곤.란.
		// 유니티에서 많이 쓰이기 때문에 잘 알아두자..
		void Message(string message) { Console.WriteLine(message); }

		void Main2()
		{
			// Func<string, void> func; // error, 반환형에 void 를 쓸 수 없다.
			Action<string> action;
			action = Message;
			Message("메세지"); // 위와 동일
		}



		// <Predicate 델리게이트>
		// 반환형이 bool, 매개변수가 하나인 델리게이트
		bool IsSentence(string str) { return str.Contains(' '); }

		void Main3()
		{
			Predicate<string> predicate;
			predicate = IsSentence;

			//int[] array = new int[5];
			//Array.Find(); find()에 마우스 가져다 대면 predicate 나옴
		}
	}
}

