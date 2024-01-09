using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_4
{
	public class FireBall : Skill
	{
		public FireBall()
		{
			coolTime = 5;
		}
		public override void Execute()
		{
			base.Execute();
			Console.WriteLine("전방에 화염구를 날립니다.\n");
		}
	}
}
