using System.Numerics;

namespace _09._OOP_Practice2_2
{
	public class Program
	{
		static void Main(string[] args)
		{
			Monster monster = new Monster();
			Player player = new Player();


			player.Standby();
			monster.Standby();

			monster.Attack(player);
			monster.Attack(player);

			player.Attack(monster);
			player.Attack(monster);

		}
	}
}