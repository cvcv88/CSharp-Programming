using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
	internal class Nullable
	{
		public class Item
		{
			public string name;
			public void Use() { }
		}
		void Main()
		{
			Item item1 = new Item();
			Item nullItem = null; // nullItem 은 갖고있는게(값이) 없다.
								  // 값형식도 값을 갖고있지않다는 null을 넣고싶다면 nullable을 쓰면된다.
								  // 물음표 붙여주기 ↓
			int? value = null;
			Item item2 = null;
			Item? item3 = null; // 위와 같은 표현
								// 
								// <Nullable 타입>
								// 값형식의 자료형들은 null을 가질 수 없음
								// 값형식에도 null을 할당할 수 있는 Nullable 타입을 지원
			bool? b = null;
			int? i = 20;

			int? value1 = null;
			if (value1 != null) Console.WriteLine(value1);
			if (b != null) Console.WriteLine(b);    // b 값이 null
			if (i.HasValue) Console.WriteLine(i);   // i 값이 있으므로 20 출력


			// <Null 조건연산자>
			// ? 앞의 객체가 null 인 경우 null 반환
			// ? 앞의 객체가 null 이 아닌경우 접근

			Item item4 = null;
			if (item4 != null)
			{
				string name = item4.name;
			}
			if (item4 != null)
			{
				item4.Use();
			}

			item4 = new Item() { name = "포션" };
			if (item4 != null)
			{
				string name = item4.name;
			}
			if (item4 != null)
			{
				item4.Use();
			}

			// 요약
			item4 = new Item() { name = "포션" };
			string name2 = item4?.name; // null이면 null 반환, null 아니면 뒤에꺼 반환
			Console.WriteLine(item4.name); // null이면 item4.name == null
			item4?.Use();



			NullClass instance = null;
			// instance.Func();                     // 예외발생 : instance가 null 이므로 접근할 객체가 없음
			Console.WriteLine(instance?.value);     // instance?.value는 null 반환
			instance?.Func();                       // instance?.Func()은 null 반환

			instance = new NullClass();
			Console.WriteLine(instance?.value);     // instance?.value는 5 반환
			instance?.Func();                       // instance?.Func()은 함수 호출


			// <Null 병합연산자>
			// ?? 앞의 객체가 null 인 경우 ?? 뒤의 객체 반환
			// ?? 앞의 객체가 null 이 아닌경우 앞의 객체 반환
			int[] array = null;
			int length = array?.Length ?? 0;        // 배열이 null 인경우 0 반환, 아닌경우 배열의 크기 반환


			// <Null 병합할당연산자>
			// ??= 앞의 객체가 null 인 경우 ??= 뒤의 객체를 할당
			// ??= 앞의 객체가 null 인 아닌경우 ??= 뒤의 객체를 할당하지 않음
			Item nullClass = null;
			nullClass ??= new Item();          // nullClass 가 null이므로 새로운 인스턴스 할당
			nullClass ??= new Item();          // nullClass 가 null이 아니므로 새로운 인스턴스 할당이 되지 않음
		}

		public class NullClass
		{
			public int value = 5;

			public void Func() { }
		}
	}
}
