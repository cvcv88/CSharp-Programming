using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
	internal class Specifier
	{
		/*******************************************************************
         * 지정자 (Specifier)
         * 
         * 델리게이트를 사용하여 미완성 상태의 함수를 구성
         * 매개변수로 전달한 지정자를 기준으로 함수를 완성하여 동작시킴
         * 기준을 정해주는 것으로 다양한 결과가 나올 수 있는 함수를 구성가능
         ********************************************************************/


		// <델리게이트를 지정자로 사용>
		// 매개변수로 함수에 필요한 기준을 전달
		// 전달한 기준을 통해 결과를 도출


		public class Item
		{
			public string name;
			public int level;
			public float weight;

			public Item(string name, int level, float weight)
			{
				this.name = name;
				this.level = level;
				this.weight = weight;
			}
		}
		void Main()
		{
			// 원하는 값 찾는 방법 1
			/*int[] array = { 3, -2, 1, -4, 9, -8, 7, -6, 5 };

            int value = -6;
            int findIndex = -1;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    findIndex = i;
                    break;
                }
            }*/

			Item[] inventory = new Item[5];

			inventory[0] = new Item("포션", 3, 3.2f);
			inventory[1] = new Item("갑옷", 2, 1.2f);
			inventory[2] = new Item("무기", 1, 4.5f);
			inventory[3] = new Item("방패", 8, 8.8f);
			inventory[4] = new Item("폭탄", 6, 12.6f);


			int findIndex = -1;
			// 1. 이름으로 찾기
			string findName = "방패";
			for (int i = 0; i < inventory.Length; i++)
			{
				if (inventory[i].name == findName)
				{
					findIndex = i;
					break;
				}
			}

			// 2. 레벨로 찾기
			int findLevel = 8;
			for (int i = 0; i < inventory.Length; i++)
			{
				if (inventory[i].level == findLevel)
				{
					findIndex = i;
					break;
				}
			}

			// 3. 무게로 찾기
			float findWeight = 12.6f;
			for (int i = 0; i < inventory.Length; i++)
			{
				if (inventory[i].weight == findWeight)
				{
					findIndex = i;
					break;
				}
			}

			// 찾기 방법이 무수히 많은데 그걸 다 구현할 수 없다.
			// 1 2 3 방법 중에서 다른 것은 찾는 조건문 뿐이다. 나머지는 다 동일
			// 찾는 조건만 델리게이트로 설정, 찾는 조건 자체를 설정한다
			// 조건의 결과값은 bool이어야 함



			int index1 = FindIndex(inventory, FindByName);
			int index2 = FindIndex(inventory, FindByWeight);

			int index3 = FindIndex(inventory, (item) => { return item.name == "방패"; });
			// 여러가지 기타 응용 바로바로 가능한 방법 = 람다식! 다음에 할거.

			// int index4 = FindIndex(inventory, value => value > 5); //배열 중 값이 5보다 큰 데이터 찾기
			// Predicate<int> predicate 일때
			Item[] finded = Array.FindAll(inventory, item => item.name.Contains("포션"));
		}

		public static bool FindByName(Item item)
		{

			return item.name == "방패"; // 맞으면 true 아니면 false
		}

		public static bool FindByWeight(Item item)
		{

			return item.weight == 6;
		}

		public static int FindIndex(Item[] inventory, Predicate<Item> predicate) // predicate = 이름으로 찾기
																				 // FindName
		{
			for (int i = 0; i < inventory.Length; i++)
			{
				if (predicate(inventory[i])) // 찾는 조건, 결과는 bool // if(이름으로 찾기) // if(FindName)
											 // 매개변수로 지정자를 어떻게 주는지를 잘 적어주면 조건으로 지정해줄수 있다.
				{
					return i;
				}
			}
			return -1;
		}

		// 함수로 매번 구성해야 한다.
		// 그때그때 기준을 만들어주는 것이 더 유용할지도..?
		// int index3 = FindIndex(inventory, (item) => { return item.name == "방패"; });
	}
}
