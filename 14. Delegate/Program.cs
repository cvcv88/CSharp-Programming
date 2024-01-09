namespace _14._Delegate
{
	internal class Program
	{

		// 턴제 배틀시스템(포켓몬스터)
		// 내가 골랐던 함수가 어떤 함수인지 잠깐 보관할 필요가 있음
		// 함수 고른액션 = 공격;


		/****************************************************************
         * 대리자 (Delegate) (대리자는 객체)
         * 
         * 특정 매개 변수 목록 및 반환 형식이 있는 ^함수에 대한 참조^
         * 대리자 인스턴스를 통해 함수를 호출 할 수 있음
         * 
         * 대신 함수를 호출해준다.
         * 함수를 보관하는 변수!!!
         ****************************************************************/

		// <델리게이트 정의>
		// delegate 반환형 델리게이트이름(매개변수들);

		public delegate float Delegate1(float left, float right);
		public delegate void Delegate2(string str);
		public static float Add(float left, float right) { return left + right; }
		public static float Minus(float left, float right) { return left - right; }

		public void Message(string message) { Console.WriteLine(message); }

		void Main1()
		{
			int value = 2;

			Delegate1 delegate1 = Add; // 함수를 보관할 수 있게 됨 == Delegate1 delegate1 = new Delegate(Add)
			float result1 = Add(1.2f, 3.4f); // 위 아래 동일함! // == delegate.Invoke(1.2f, 3.4f);
			float result2 = delegate1(1.2f, 3.4f); // 보관된 함수 사용하는 예 (== 4.6f)

			delegate1 = Minus;
			float result3 = delegate1(3.4f, 1.2f); // (== 2.2f)

			// delegate1 = Message; // error 델리게이트는 반환형과 매개변수들이 일치하는 함수만 참조가능
			// 왜? 함수는 매개변수랑 반환형을 기준으로 구분하는데 message와 delegate1의
			// 매개변수와 반환형이 다르기 때문이다. (float /= void, string)

			Delegate2 delegate2 = Message;
			delegate2("메세지");
			// delegate2 = Add(); // error!


		}






		static void Main(string[] args)
		{
			int[] array = { 2, 5, -4, 3, 10, -9, -8 };
			Array.Sort(array); // 오름차순 정렬
			Array.Reverse(array); // 내림차순 정렬

			Array.Sort(array, Comparer<int>.Create((a, b) => { return b - a; })); // 내림차순

			int[] find1 = Array.FindAll(array, value => value < 5); // 5보다 작은 값 모두 찾기
			for (int i = 0; i < find1.Length; i++)
			{
				Console.WriteLine(find1[i]);
			}
			int[] find2 = Array.FindAll(array, value => Math.Abs(value) < 5); // 절대값 5보다 작은 값 모두 찾기
		}
	}
}
