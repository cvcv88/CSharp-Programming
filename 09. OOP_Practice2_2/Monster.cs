using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_2
{
	public class Monster
	{
		string name;
		int hp;
		public int damage;

		public Monster()
		{
			name = "Slime";
			hp = 1000;
			damage = 10;
		}

		public void Standby()
		{
			Console.WriteLine("=======================");
			Console.WriteLine($"몬스터 이름 : {name}");
			Console.WriteLine($"몬스터 체력 : {hp}");
			Console.WriteLine($"몬스터 공격력 : {damage}");
			Console.WriteLine("=======================\n");
		}

		public void Attack(Player yj)
		{
			Console.WriteLine($"{name}이 공격합니다!");
			yj.TakeHitPlayer(damage);
		}

		public void TakeHitMonster(int damage)
		{
			Console.WriteLine($"{name}은 {damage}만큼 피해를 입었습니다.\n");
			hp -= damage;
			Console.WriteLine($"<<현재 {name}의 체력 : {hp}>>\n\n");
		}

	}
}
