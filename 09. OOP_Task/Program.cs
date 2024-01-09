namespace _09._OOP_Task
{
	internal class Program
	{
		public class Cookie
		{
			protected string name;
			protected string skill;

			protected int hp;
			protected int damage;

			protected int selfHeal;

			public void PrintCookieProfile()
			{
				Console.WriteLine("========================");
				Console.WriteLine($"쿠키 이름 : {name}\n스킬 이름 : {skill}\n체력 : {hp}, 공격력 : {damage}");
				Console.WriteLine("========================\n");
			}
			public void Attack(Cookie cookie)
			{
				Console.WriteLine($"{name}가 {skill} 스킬로 {damage}의 공격을 합니다!");
				cookie.hp -= this.damage;
				Console.WriteLine($"{cookie.name}가 체력이 {cookie.hp}이/가 되었습니다.\n");
			}

			public void SelfHeal()
			{
				if (selfHeal > 0)
				{
					Console.WriteLine($"{name}가 {selfHeal}만큼의 체력 회복을 합니다");
					hp += selfHeal;
					Console.WriteLine($"{name}의 현재 체력이 {hp}가 되었습니다.\n");
				}
				else
				{
					Console.WriteLine("{name}자가 치유 스킬이 없어서 체력 회복에 실패했습니다.\n");
				}
			}
		}

		public class BraveCookie : Cookie
		{
			public BraveCookie()
			{
				name = "용감한 쿠키";
				skill = "용감한 돌격";

				hp = 100;
				damage = 10;

				selfHeal = 0;
			}

		}

		public class CustardCookie : Cookie
		{
			public CustardCookie()
			{
				name = "커스터드 3세맛 쿠키";
				skill = "훌륭한 왕!";

				hp = 70;
				damage = 10;

				selfHeal = 5;
			}
		}

		public class SpecialCookie : Cookie
		{
			protected string ultmate;
			protected int ult_damage;

		}

		public class VampireCookie : SpecialCookie
		{

			public VampireCookie()
			{
				name = "뱀파이어맛 쿠키";
				skill = "흡혈";

				hp = 500;
				damage = 100;

				ultmate = "치명적인 흡혈";
				ult_damage = 100;
			}
		}

		static void Main(string[] args)
		{
			BraveCookie bravecookie = new BraveCookie();
			CustardCookie custardcookie = new CustardCookie();

			bravecookie.PrintCookieProfile();
			custardcookie.PrintCookieProfile();

			bravecookie.Attack(custardcookie);
			custardcookie.Attack(bravecookie);

			bravecookie.SelfHeal();
			custardcookie.SelfHeal();
		}
	}
}