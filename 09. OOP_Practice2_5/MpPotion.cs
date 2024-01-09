using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_5
{
	public class MpPotion : Item
	{
		public override void Use()
		{
			Console.WriteLine("MP 포션을 사용해서 MP를 채웁니다.");
		}
	}
}
