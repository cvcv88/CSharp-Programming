using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_3
{
	public class Slime : Monster
	{
		public Slime()
		{
			name = "귀여운 슬라임";
			hp = 50;
			damage = 3;
			PrintInfo();
		}

		public void Split()
		{
			Console.WriteLine($"{name} 이/가 분열했습니다!");
		}
	}
}
