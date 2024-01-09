using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_1
{
	public class Driver
	{
		string name;
		public Driver()
		{
			name = "유정";
		}
		public void Start(Car car)
		{
			Console.WriteLine($"운전자 {name}의 {car.name} 운전이 시작됩니다\n");
		}

		public void Accel(Car car)
		{
			car.Move();
			Console.WriteLine($"현재 속도 : {car.speed}\n");
		}

		public void PowerAccel(Car car)
		{
			car.SuperMove();
			Console.WriteLine($"현재 속도 : {car.speed}\n");
		}

		public void brake(Car car)
		{
			car.Slow();
			Console.WriteLine($"현재 속도 : {car.speed} \n");
		}
		public void Powerbrake(Car car)
		{
			car.SuperSlow();
			Console.WriteLine($"현재 속도 : {car.speed} \n");
		}
		public void Stop(Car car)
		{
			car.speed = 0;
			Console.WriteLine($"속도를 {car.speed} (으)로 줄입니다...");
			Console.WriteLine($"운전자 {name}의 {car.name} 운전이 종료되었습니다! \n운전하느라 수고링~\n");
		}
	}
}
