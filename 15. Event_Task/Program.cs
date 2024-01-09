namespace _15._Event_Task
{
	internal class Program
	{
		public class Player
		{
			// 이벤트
			public Action OnTakeDamage;

			public void Equip(Equipment equipment)
			{
				// 방어구 착용 구현
				Console.WriteLine("플레이어가 장비를 착용합니다.");
				equipment.EquipedBy(this);
			}

			public void UnEquip(Equipment equipment)
			{
				// 방어구 해제 구현
				Console.WriteLine("플레이어가 장비를 해제합니다.");
				equipment.UnEquipedBy(this);
			}

			public void TakeDamage(int damage)
			{
				// 이벤트 발생 구현
				Console.WriteLine("플레이어가 데미지를 받습니다.");
				if (OnTakeDamage != null)
					OnTakeDamage();
			}
		}

		public class Equipment
		{
			public event Action<Equipment> OnBreak;

			int durability = 3;

			public void EquipedBy(Player player)
			{
				player.OnTakeDamage += TakeDamage;
				OnBreak += player.UnEquip;
			}

			public void UnEquipedBy(Player player)
			{
				player.OnTakeDamage -= TakeDamage;
				OnBreak -= player.UnEquip;
			}

			public void TakeDamage()
			{
				// 피격시 행동 구현
				durability--;
				Console.WriteLine($"방어구가 데미지를 받아 {durability} 내구도가 됩니다.");

				if (durability <= 0)
				{
					Break();
				}
			}

			private void Break()
			{
				Console.WriteLine("장비가 부셔집니다.");

				if (OnBreak != null)
					OnBreak(this);
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
		}
	}
}
