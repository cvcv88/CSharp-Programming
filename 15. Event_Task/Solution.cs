using System.Data;

namespace Test
{
	internal class Solution
	{
		public class Player
		{
			public Action OnTakeDamage;
			public void Equip(Equipment equipment)
			{
				Console.WriteLine("플레이어가 장비를 착용합니다.");
				OnTakeDamage += equipment.TakeDamage;
				// 장비 착용 후 데미지 받으면 플레이어의 장비에 변화 생김
				equipment.OnBreak += UnEquip;
				// onBreak에 UnEquip 저장시켜두기.
			}
			public void UnEquip(Equipment equipment)
			{
				Console.WriteLine("플레이어가 장비를 해제합니다.");
				OnTakeDamage -= equipment.TakeDamage;
				// equipment.OnBreak -= UnEquip;
			}

			public void TakeDamage(int damage)
			{
				// 이벤트 발생
				Console.WriteLine("플레이어가 데미지를 받습니다.");
				if (OnTakeDamage != null)
					OnTakeDamage();
			}
		}

		public class Equipment
		{
			public event Action<Equipment> OnBreak;
			int durability = 3;
			public void TakeDamage()
			{
				// 피격시 행동
				durability--;
				Console.WriteLine($"방어구가 데미지를 받아 {durability} 내구도가 됩니다.");

				if (durability <= 0)
				{
					Break();
				}
			}

			public void Break()
			{
				Console.WriteLine("장비가 산산조각났습니다.");
				if (OnBreak != null)
					OnBreak(this); // 무엇이 부셔지는지 알려줘야 함!!
			}
		}

		static void Main(string[] args)
		{
			Player player = new Player();
			Equipment ammor = new Equipment();

			player.Equip(ammor);

			player.TakeDamage(1);
			player.TakeDamage(1);
			player.TakeDamage(1);
			player.TakeDamage(1);
			player.TakeDamage(1);


		}
	}
}