using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_3
{
	public class Dragon : Monster
	{
		public Dragon()
		{
			name = "이재용";
			hp = 1000;
			damage = 500;
			PrintInfo();
		}

		public void Rich()
		{
			Console.WriteLine($"{name} 이/가 더 부자가 되었습니다.");
		}
	}
}
