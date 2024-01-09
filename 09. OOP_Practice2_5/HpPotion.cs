using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_5
{
	public class HpPotion : Item
	{
		public override void Use()
		{
			Console.WriteLine("HP 포션을 사용해서 HP를 채웁니다.");
		}
	}
}
