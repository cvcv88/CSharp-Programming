using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_3
{
	public class Monster
	{
		protected string name;
		protected int hp;
		protected int damage;

		public Monster()
		{

		}

		protected void PrintInfo()
		{
			Console.WriteLine($"=====================");
			Console.WriteLine($"몬스터 이름 : {name}");
			Console.WriteLine($"몬스터 체력 : {hp}");
			Console.WriteLine($"몬스터 공격력 : {damage}");
			Console.WriteLine($"=====================");
		}

		public void Move()
		{
			Console.WriteLine($"{name} 이/가 움직입니다!");
		}

		public void Attack()
		{
			Console.WriteLine($"{name} 이/가 {damage} 의 공격력으로 공격합니다!");
		}

	}
}
