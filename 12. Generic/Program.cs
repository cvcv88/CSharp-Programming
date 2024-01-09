namespace _12._Generic
{
	internal class Program
	{

		/* * * * * * *  
		 * 일반화 (Generic)
         * 
         * 클래스 또는 함수가 코드에 의해 선언되고 인스턴스화될 때까지 형식의 사양을 연기하는 디자인
         * 기능을 구현한 뒤 자료형을 사용 당시에 지정해서 사용
		 * * * * * * */

		// <일반화 함수>
		// 일반화가 없는 경우 자료형마다 함수를 작성
		public static void IntArrayCopy(int[] source, int[] output)
		{
			for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
		}

		public static void FloatArrayCopy(float[] source, float[] output)
		{
			for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
		}

		public static void DoubleArrayCopy(double[] source, double[] output)
		{
			for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
		}

		// 일반화를 이용하면 위 함수들과 다른 자료형의 함수 또한 호환할 수 있음
		// T : 내 맘대로 적어도 됨, 자료형 이름...
		public static void ArrayCopy<T>(T[] source, T[] output)
		{
			for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
		}

		void Main1()
		{
			int[] iSrc1 = { 1, 2, 3, 4, 5 };
			int[] iOut1 = new int[5];

			ArrayCopy(iSrc1, iOut1);

			float[] fSrc2 = { 1f, 2f, 3f, 4f, 5f };
			int[] fOut1 = new int[5];
			// ArrayCopy(fSrc2, fOut1); // error 매개변수 자료형과 다르기 때문


			int[] iSrc = { 1, 2, 3, 4, 5 };
			int[] iOut = new int[5];
			ArrayCopy<int>(iSrc, iOut);

			float[] fSrc = { 1f, 2f, 3f, 4f, 5f };
			float[] fOut = new float[5];
			ArrayCopy<float>(fSrc, fOut);

			char[] cSrc = { 'a', 'b', 'c' };
			char[] cOut = new char[3];
			ArrayCopy<char>(cSrc, cOut);
		}


		// <일반화 클래스>
		// 클래스에 필요한 자료형을 일반화하여 구현
		// 이후 클래스 인스턴스를 생성할 때 자료형을 지정하여 사용
		public class SafeArray<Type>
		{
			Type[] array;

			public SafeArray(int size)
			{
				array = new Type[size];
			}

			public void Set(int index, Type value)
			{
				if (index < 0 || index >= array.Length)
					return;

				array[index] = value;
			}

			public Type Get(int index)
			{
				if (index < 0 || index >= array.Length)
					return default(Type);      // default : Type 자료형의 기본값

				return array[index];
			}
		}

		void Main2()
		{
			SafeArray<int> intArray;
			SafeArray<float> floatArray;
		}

		public static Type Bigger<Type>(Type left, Type right)
		{
			if (left > right) // 안되는 이유? 비교가 불가능한 자료형이 들어올 수도 있기때문 ex) string
			{
				return left;
			}
			else
			{
				return right;
			}
		}

		void Main3()
		{
			int intBigger = Bigger<int>(1, 2);
			bool boolBigger = Bigger<bool>(true, true); // 곤란! 판단 불가 자료형
														// 일부 자료형만 지원하는 작업들은 일반화 사용 불가
		}


		// <일반화 자료형 제약>
		// 일반화 자료형을 선언할 때 제약조건을 선언하여, 사용 당시 쓸 수 있는 자료형을 제한

		// 형식 = where 자료형 : 자료형이 갖고 있어야하는 특징
		// ex) class, class Monster, struct, new() ...

		// IComparable : int double 비교할 수 있는 인터페이스 갖고 있는 자료형만 제한
		public static Type Bigger2<Type>(Type left, Type right) where Type : IComparable
		{
			if (left.CompareTo(right) < 0) // IComparable의 특징 제한 = IComparable의 기능 사용 가능
			{
				return left;
			}
			else
			{
				return right;
			}
		}

		class Player { }
		void Main4()
		{
			int intBigger = Bigger2<int>(5, 3);
			float floatBigger = Bigger2<float>(2.1f, 3.8f);

			bool boolBigger = Bigger2<bool>(true, false);

			// Player player = Bigger2<Player>(new Player(), new Player()); // error! 
		}

		// : class, : struct : 값인지 참조인지도 제약사항으로 가능
		class StructT<T> where T : struct { }           // T는 구조체만 사용 가능
		class ClassT<T> where T : class { }             // T는 클래스만 사용 가능
		class NewT<T> where T : new() { }               // T는 매개변수 없는 생성자가 있는 자료형만 사용 가능

		class ParentT<T> where T : Parent { }           // T는 Parent 파생클래스만 사용 가능
		class InterfaceT<T> where T : IComparable { }   // T는 인터페이스를 포함한 자료형만 사용 가능

		class Parent { }
		class Child : Parent { }

		void Main5()
		{
			StructT<int> structT = new StructT<int>();          // int는 구조체이므로 struct 제약조건이 있는 일반화 자료형에 사용 가능
																// ClassT<int> classT = new ClassT<int>();          // error : int는 구조체이므로 class 제약조건이 있는 일반화 자료형에 사용 불가
			NewT<int> newT = new NewT<int>();                   // int는 new int() 생성자가 있으므로 사용 가능

			ParentT<Parent> parentT = new ParentT<Parent>();    // Parent는 Parent 파생클래스이므로 사용 가능
			ParentT<Child> childT = new ParentT<Child>();       // Child는 Parent 파생클래스이므로 사용 가능
			InterfaceT<int> interT = new InterfaceT<int>();     // int는 IComparable 인터페이스를 포함하므로 사용 가능
		}


		// <일반화 제약 용도>
		// 일반화 자료형에 제약조건이 있다면 포함가능한 자료형의 기능을 사용할 수 있음
		public class BaseClass
		{
			public void Start()
			{
				Console.WriteLine("Start");
			}
		}

		public void Main5<T>(T param) where T : BaseClass
		{
			param.Start();      // 일반화 자료형의 제약조건이 BaseClass 클래스이므로, BaseClass의 기능을 사용 가능 
		}


		static void Main(string[] args)
		{

		}
	}
}