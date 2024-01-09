using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_2
{
	public class Player
	{
		string name;
		int hp;
		public int damage;
		public Player()
		{
			name = "유정";
			hp = 500;
			damage = 50;
		}

		public void Standby()
		{
			Console.WriteLine("=======================");
			Console.WriteLine($"플레이어 이름 : {name}");
			Console.WriteLine($"플레이어 체력 : {hp}");
			Console.WriteLine($"플레이어 공격력 : {damage}");
			Console.WriteLine("=======================\n");
		}

		public void TakeHitPlayer(int damage)
		{
			Console.WriteLine($"{name}은 {damage}만큼 피해를 입었습니다. \n");
			hp -= damage;
			Console.WriteLine($"<<현재 {name}의 체력 : {hp}>>\n\n");
		}

		public void Attack(Monster monster)
		{
			Console.WriteLine($"{name}이 공격합니다!");
			monster.TakeHitMonster(damage);
		}
	}
}
