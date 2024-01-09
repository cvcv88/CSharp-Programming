namespace _09._OOP_Practice2_3
{
	public class Program
	{
		static void Main(string[] args)
		{
			Dragon dragon = new Dragon();
			Slime slime = new Slime();
			Ock ock = new Ock();

			dragon.Move();
			slime.Move();
			ock.Move();

			Console.WriteLine();

			dragon.Attack();
			slime.Attack();
			ock.Attack();

			Console.WriteLine();

			dragon.Rich();
			slime.Split();
			ock.Rage();
		}
	}
}