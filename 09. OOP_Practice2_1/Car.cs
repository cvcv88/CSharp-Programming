using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_1
{
	public class Car
	{
		public string name;
		public int speed;
		public Car()
		{
			name = "오도방구";
		}
		public void Move()
		{
			if (speed <= 110)
			{
				speed += 10;
			}
			else
			{
				speed = 120;
			}
		}
		public void SuperMove()
		{
			if (speed <= 90)
			{
				speed += 30;
			}
			else
			{
				speed = 120;
			}
		}
		public void Slow()
		{
			if (speed >= 10)
			{
				speed -= 10;
			}
			else
			{
				speed = 0;
			}
		}
		public void SuperSlow()
		{
			if (speed >= 30)
			{
				speed -= 30;
			}
			else
			{
				speed = 0;
			}
		}
	}
}
