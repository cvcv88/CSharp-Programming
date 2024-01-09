using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_4
{
	public class Skill
	{
		protected int coolTime;
		public virtual void Execute()
		{
			Console.WriteLine("스킬 쿨타임 기다리는 중..");
			Console.WriteLine($"스킬 재사용 대기 시간 : {coolTime}초");
		}
	}
}
