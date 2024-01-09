namespace _13._Exception_Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("첫 번째 숫자를 입력하세요.");
			string x = Console.ReadLine();
			Console.WriteLine("두 번째 숫자를 입력하세요.");
			string y = Console.ReadLine();

			int num1 = int.Parse(x);
			int num2 = int.Parse(y);

			if (num2 != 0)
			{
				Console.WriteLine($"{num1} / {num2} == {num1 / num2}");
			}
			else
			{
				Console.WriteLine("0으로 나눌 수 없습니다.");
				Console.WriteLine($"{num1} / {num2} == {int.MaxValue}");
			}



			/*try
			{
				int result = num1 / num2;
				Console.WriteLine($"{num1} / {num2} == {result}");
			}
			catch(Exception ex)
			{
				Console.WriteLine("0으로 나눌 수 없습니다.");
			}*/

		}
	}
}
