using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice_Solve
{
	public class Driver
	{
		public void SpeedUp(Car car)
		{
			Console.WriteLine("드라이버가 차를 가속합니다.");
			car.Accel();
		}

		public void SpeedDown(Car car)
		{
			Console.WriteLine("드라이버가 차를 감속합니다.");
			car.Brake();
		}
	}
}
