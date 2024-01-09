namespace _09._OOP_Practice2_1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			Driver driver = new Driver();

			driver.Start(car);

			driver.Accel(car);
			driver.PowerAccel(car);
			driver.PowerAccel(car);
			driver.PowerAccel(car);
			driver.PowerAccel(car);

			driver.brake(car);
			driver.Powerbrake(car);

			driver.Stop(car);
		}
	}
}