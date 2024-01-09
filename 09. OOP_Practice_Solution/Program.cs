using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice_Solve
{
	public class Program
	{
		static void Main(string[] args)
		{
			Driver driver = new Driver();
			Car car = new Car();

			driver.SpeedUp(car);
			driver.SpeedUp(car);
			driver.SpeedUp(car);
			driver.SpeedUp(car);
			driver.SpeedDown(car);
		}
	}
}
