namespace _09._OOP_Practice2_5
{
	public class Program
	{
		/*abstract class Item
		{
			public abstract void Use();
		}

		class Potion : Item
		{
			public override void Use()
			{
				Console.WriteLine("포션을 사용하여 체력을 회복합니다.");
			}
		}

		class Herb : Item
		{
			public override void Use()
			{
				Console.WriteLine("허브를 사용하여 독상태를 해제합니다.");
			}
		}
		static void Main(string[] args)
		{
			Item potion = new Potion();
			potion.Use();

			Item herb = new Herb();
			herb.Use();
		}*/

		static void Main(string[] args)
		{
			Item hppotion = new HpPotion();
			hppotion.Use();

			Item mppotion = new MpPotion();
			mppotion.Use();

			Item herb = new Herb();
			herb.Use();
		}
	}
}