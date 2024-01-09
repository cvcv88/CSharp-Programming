using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_3
{
	public class Ock : Monster
	{
		public Ock()
		{
			name = "5크";
			hp = 500;
			damage = 40;
			PrintInfo();
		}

		public void Rage()
		{
			Console.WriteLine($"{name} 이/가 분노상태가 되었습니다!");
		}
	}
}
