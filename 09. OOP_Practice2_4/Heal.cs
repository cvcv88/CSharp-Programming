using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_4
{
	public class Heal : Skill
	{
		public Heal()
		{
			coolTime = 10;
		}
		public override void Execute()
		{
			base.Execute();
			Console.WriteLine("아군의 체력을 회복시킵니다!\n");
		}
	}
}
