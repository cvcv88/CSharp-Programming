using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_5
{
	public class Herb : Item
	{
		public override void Use()
		{
			Console.WriteLine("해독초를 통해 독 상태에서 풀려났습니다.");
		}
	}
}
