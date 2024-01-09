namespace _09._OOP_Practice2_4
{
	public class Program
	{
		static void Main(string[] args)
		{
			Skill fireBall = new FireBall();
			fireBall.Execute();

			Skill Heal = new Heal();
			Heal.Execute();

			Player player = new Player();
			/*player.SetSkill(fireBall);
			player.UseSkill();

			player.SetSkill(Heal);
			player.UseSkill();*/

			player.SetQSkill(fireBall);
			player.SetESkill(Heal);
			player.UseQSkill();
			player.UseESkill();



		}
	}
}