using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace _10._Interface_Task
{
	public class Program
	{
		/*class Member : IComparable
		{
			string name;
			public Member(string name)
			{
				this.name = name;
			}

			public int CompareTo(object? obj)
			{
				Member member = obj as Member; // obj 객체 생성
				return name.CompareTo(member.name); // name 순으로 정렬하는 구문
			}
			public override string ToString()
			{
				return string.Format("이름:{0}", name);
			}
		}

		static void Main(string[] args)
		{
			*/
		/*int[] arr = new int[10] { 20, 10, 5, 9, 11, 23, 8, 7, 6, 13 };
		Array.Sort(arr);

		foreach (int i in arr)
		{
			Console.WriteLine("{0}", i);
		}
		Console.WriteLine();


		ArrayList ar = new ArrayList();
		ar.Add(4);
		ar.Add(8);
		ar.Add(2);

		ar.Sort(); // 개체의 멤버 메서드 Sort를 이용

		foreach (int i in ar)
		{
			Console.Write("{0} ", i);
		}
		Console.WriteLine();*/

		/*
		Member[] members = new Member[3];
		members[0] = new Member("다땡땡");
		members[1] = new Member("하뿅뿅");
		members[2] = new Member("가이름");

		Array.Sort(members); // 배열 정렬 구문

		foreach (Member member in members)
		{
			Console.WriteLine(member);
		}
	}*/

		/*class Item : IComparable
		{
			string name;

			public Item(string item)
			{
				this.name = item;
			}

			public int CompareTo(Object? obj)
			{
				Item item = obj as Item;
				return name.CompareTo(item.name);
			}

			public override string ToString()
			{
				return string.Format($"아이템 이름 : {name}");
			}
		}
		static void Main(string[] args)
		{
			Item[] items = new Item[5];
			items[0] = new Item("체력 포션");
			items[1] = new Item("마나 포션");
			items[2] = new Item("만병통치약");
			items[3] = new Item("엘릭서");
			items[4] = new Item("버프 물약");

			Array.Sort(items);

			foreach(Item item in items)
			{
				Console.WriteLine(item);
			}
		}*/


		// 내가 혼자 한거!!! ToString 빼고 ㅎㅎ
		class Item : IComparable
		{
			string name;

			public Item(string name)
			{
				this.name = name;
			}
			public int CompareTo(object? obj)
			{
				if (obj == null) throw new NotImplementedException();

				Item item = obj as Item;
				return this.name.CompareTo(item.name);
			}
			public override string ToString()
			{
				return string.Format($"아이템 이름 : {name}");
			}
		}

		static void Main(string[] args)
		{
			Item[] items = new Item[5];
			items[0] = new Item("체력 포션");
			items[1] = new Item("마나 포션");
			items[2] = new Item("만병통치약");
			items[3] = new Item("엘릭서");
			items[4] = new Item("버프 물약");

			Array.Sort(items);

			foreach (Item item in items)
			{
				Console.WriteLine(item);
			}
		}

	}
}