namespace _02._Operator_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const float HCOE = 10.3f;    // 체력 증가
			const float DCOE = 15.9f;   // 데미지 증가
			const float GCOE = 9.9f;    // 방어력 증가
			const float ATTACK = 5.5f;  // 스킬 증가

			string name;
			int level;

			float hp = 180;
			float damage = 105;
			float guard = 100;
			float skill;

			Console.WriteLine("캐릭터 이름을 입력해주세요!");
			Console.Write("캐릭터 : ");
			name = Console.ReadLine();

			Console.WriteLine("\n캐릭터의 레벨을 입력해주세요!(1 ~ 80)");
			Console.Write("레벨 : ");
			level = int.Parse(Console.ReadLine());

			Console.WriteLine($"\n선택한 캐릭터 : {name}, {level}레벨!");

			hp += (level - 1) * HCOE;
			damage += (level - 1) * DCOE;
			guard += (level - 1) * GCOE;
			skill = damage + (level - 1) * ATTACK;

			Console.WriteLine($"체력 : {hp:f1}");
			Console.WriteLine($"데미지 : {damage:f1}");
			Console.WriteLine($"방어력 : {guard:f1}");
			Console.WriteLine($"스킬 피해량 : {skill:f1}");
		}
	}
}