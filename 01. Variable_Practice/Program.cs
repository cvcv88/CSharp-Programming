namespace _01._Variable_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 과제
			string name;
			string job;
			int level;
			int hp;

			Console.WriteLine("<캐릭터 선택창>\n");
			Console.Write("이름을 입력하세요 : ");
			name = Console.ReadLine();

			Console.Write("직업을 입력하세요 : ");
			job = Console.ReadLine();

			Console.Write("레벨을 입력하세요 : ");
			level = int.Parse(Console.ReadLine());

			Console.Write("체력을 입력하세요 : ");
			hp = int.Parse(Console.ReadLine());

			Console.WriteLine("\n선택하신 캐릭터는");
			Console.WriteLine($"이름 : {name}");
			Console.WriteLine($"직업 : {job}");
			Console.WriteLine($"레벨 : {level}");
			Console.WriteLine($"체력 : {hp}");
		}
	}
}