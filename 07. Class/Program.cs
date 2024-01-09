using System.Text.RegularExpressions;

namespace _07._Class
{
	internal class Program
	{
		/* * * * * * *  
		 * 클래스 (class)
		 * 
		 * 데이터와 관련 기능을 캡슐화할 수 있는 ^참조^ 형식
		 * 객체지향 프로그래밍에 객체를 만들기 위한 설계도
		 * 클래스는 객체를 만들기 위한 설계도이며, 만들어진 객체는 인스턴스라 함
		 * 참조 : 원본을 가리키고 있음 == 원본의 주소를 가지고 있음
		 * * * * * * */

		// <클래스 구성>
		// class 클래스이름 { 클래스내용 }
		// 클래스 내용으로는 변수와 함수가 포함 가능

		// 구조체와 클래스의 차이는 거의 없다.
		// 가장 큰 차이 : 구조체는 값 형식(보관 단위용), 클래스는 참조 형식(객체생성용)이다.
		class Student
		{
			public string name;
			public int math;
			public int english;
			public int science;

			public float GetAverage()
			{
				return (math + english + science) / 3f;
			}
		}
		static void Main1(string[] args)
		{
			Student kim = new Student();
			kim.name = "김땡땡";
			kim.math = 70;
			kim.english = 85;
			kim.science = 90;

			float average = kim.GetAverage();
		}


		// <클래스 생성자>
		// 반환형이 없는 클래스이름의 함수를 생성자라 하며 클래스의 인스턴스를 만들 때 호출되는 역할로 사용
		// 인스턴스의 생성자는 new 키워드를 통해서 사용

		// 클래스 이름과 동일하고, 반환형이 없는 함수를 생성자라고 한다.
		// 클래스의 인스턴스(객체가 만들어진 상태)를 만들 때 호출되는 역할로 사용.
		// Main 안에서 new를 통해 객체(인스턴스)를 만들고 초기화(초기 값 설정)을 하려면 생성자가 필요하다.

		// 구조체는 초기화(구조체 변수를 초기화)라고 하고, 클래스는 생성자(클래스의 인스턴트[객체]를 만듦)라고 함.

		// 클래스는 생성자를 아예 만들지 않았으면 자동으로 생성자가 생기고 기본값이 들어가는데,
		// 만약 어떠한 생성자를 만들었다면 기본값이 생성되지 않는다.

		class Car
		{
			public string name;
			public string color;

			public Car(string name, string color)
			{
				this.name = name;
				this.color = color;
			}
		}

		static void Main2(string[] args)
		{
			Car truck = new Car("트럭", "파란색");
			Console.WriteLine($"{truck.name}, {truck.color}"); // 트럭, 파란색

			// car sportCar = new Car() { name = "스포츠카", color = "빨간색" };

			// car sportCar = new Car() { name = "스포츠카" };
			// car sportCar = new Car() { color = "빨간색" };

			// 클래스 생성하자마자 초기화시켜주는 문법 지원해줌
			// 무슨차이야??

			// 생성자 wing
			// public Car(string name, string color, int year) : this(name, color){this.year = year};


			Car car;
			// car.name = "차"; // 변수만 만들고 안의 값 바꿔주는거 불가능함. error
			// 구조체는 가능은 했지만, 클래스는 아직 인스턴스가 new 해서 만들어 지지 않았기때문이다.

			// 구조체 : 데이터 집합, 구조체 변수가 구조체의 구성들을 가지고 있는 데이터 집합이 됨.
			// 클래스 : 클래스 변수는 객체를 가리키는 주소가 들어간다. 클래스 변수 안에 실제 값 가지고 있는거 X
			// new 생성자 : 실제로 객체를 만드는 행위, 새로운 객체를 만드는 것.

			// 클래스 변수는 실제 값을 가지고 있는 게 아니라 new 새로 만든 객체의 주소를 가지고 있다. 원본은 따로 있음.
			// 클래스 : 설계도, 붕어빵 틀 / new 를 통해 만든 것 : 완성품, 붕어빵 .
		}


		// <클래스 얕은복사>
		// 클래스에 대입연산자(=)를 통해 같은 인스턴스를 참조함
		// 얕은 복사인 이유 : 값 자체에 접근해서 값을 바꾸는게 아니라 주소를 이용해서 값을 변경하기 때문에.
		class MyClass
		{
			public int value1;
			public int value2;
		}

		static void Main3(string[] args)
		{
			MyClass s = new MyClass();
			s.value1 = 1;
			s.value2 = 2;
			// t는 s가 가리키는 인스턴스를 가리킴 -> t와 s는 같은 인스턴스를 가리키게 됨
			MyClass t = s;      // 변수가 같은 인스턴스를 참조함
			t.value1 = 3;

			// 같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경됨
			Console.WriteLine(s.value1);    // 3 구조체인경우 1
			Console.WriteLine(s.value2);    // 2 구조체인경우 2

			Console.WriteLine(t.value1);    // 3 구조체인경우 3
			Console.WriteLine(t.value2);    // 2 구조체인경우 2
		}

		// 왜 이렇게까지 해야할까?
		// 원본을 만들어놓고 누구든지 원본을 사용할 수 있게 하는 경우일때 사용하기 좋다.





		/* * * * * * *  
		 * 값형식, 참조형식
		 * 
		 * 값형식 (Value type) : 
         * 복사할 때 실제값이 복사됨 (깊은 복사)
         * 구조체는 값형식
         * 
         * 참조형식 (Reference type) : 
         * 복사할 때 객체주소가 복사됨 (얕은 복사)
         * 클래스는 참조형식
		 * * * * * * */

		// <값형식과 참조형식의 차이>
		// 값형식 : 데이터가 중요한 경우 사용, 값이 복사됨
		// 참조형식 : 객체가 중요한 경우 사용, 객체주소가 복사됨

		// 무조건 정확히 알아야 하는 것. 면집 질문 출제율 100%
		// 구조체, 클래스 차이 = 값형식, 참조형식 = call by value, reference = boxing, unboxing 다 동일한 말.

		struct ValueType
		{
			public int value;
		}

		class RefType
		{
			public int value;
		}

		static void Main4(string[] args)
		{
			ValueType valueType1 = new ValueType() { value = 10 };
			ValueType valueType2 = valueType1;      // 값이 복사
			valueType2.value = 20;                  // 값을 대입해도 원본에는 영향 없음
			Console.WriteLine(valueType1.value);    // output : 10

			RefType refType1 = new RefType() { value = 10 };
			RefType refType2 = refType1;            // 객체주소가 복사
			refType2.value = 20;                    // 값을 대입하는 경우 원본 데이터를 변경
			Console.WriteLine(refType1.value);      // output : 20
		}





		// <값에 의한 호출, 참조에 의한 호출>
		// 값에 의한 호출 (Call by value) : 
		// 값형식의 데이터가 전달되며 데이터가 복사되어 전달됨
		// 함수의 매개변수로 전달하는 경우 복사한 값이 전달되며 원본은 유지됨
		static void Swap(ValueType left, ValueType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}

		// 참조에 의한 호출 (Call by reference) :
		// 참조형식의 데이터가 전달되며 주소가 복사되어 전달됨
		// 함수의 매개변수로 전달하는 경우 주소가 전달되며 주소를 통해 접근하기 때문에 원본을 전달하는 효과
		static void Swap(RefType left, RefType right)
		{
			int temp = left.value;
			left.value = right.value;
			right.value = temp;
		}

		static void Main(string[] args)
		{
			ValueType leftValue = new ValueType() { value = 10 };
			ValueType rightValue = new ValueType() { value = 20 };
			Swap(leftValue, rightValue);    // 데이터의 복사본이 함수로 들어가기 때문에 원본이 바뀌지 않음
			Console.WriteLine($"{leftValue.value}, {rightValue.value}");    // output : 10, 20

			RefType leftRef = new RefType() { value = 10 };
			RefType rightRef = new RefType() { value = 20 };
			Swap(leftRef, rightRef);        // 원본의 주소가 함수로 들어가기 때문에 원본이 바뀜
			Console.WriteLine($"{leftRef.value}, {rightRef.value}");        // output : 20, 10
		}




		// <얕은복사, 깊은복사>
		// 얕은복사 (Shallow copy) : 객체를 복사할 때 주소값만을 복사하여 같은 원본을 가리키게 함
		// 깊은복사 (Depp copy) : 객체를 복사할 때 주소값 안의 원본을 복사하여 다른 객체를 가지고 가리키게 함

		// 깊은 복사 방법 : 똑같이 new class해서 객체를 만들고, 객체의 원본을 복사, 가리키게 한다.

		// 얕은 복사가 필요한 때 : 같은 대상을 바라봄(깊복일때 : 또다른 플레이어 따라다님, 몬스터 - 플레이어)
		// 깊은 복사가 필요한 때 : 각자 다른 아이템 획득(얕복 : 하나밖에 못먹었는데 다른 아이템 사라짐, 아이템 - 플레이어)
		class CopyConstructor
		{
			public RefType shallow;
			public RefType deep;

			public CopyConstructor(CopyConstructor other)
			{
				// 얕은복사
				this.shallow = other.shallow;

				// 깊은복사
				this.deep = new RefType();
				this.deep.value = other.deep.value;
			}
		}


		static void Main6(string[] args)
		{
			// 데이터가 중요할때는 구조체
			// 어떤 객체, 대상 자체가 필요할 때는 클래스
		}
	}
}