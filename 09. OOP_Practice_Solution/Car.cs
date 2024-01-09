namespace _09._OOP_Practice_Solve
{
	public class Car
	{
		private int speed;

		public void Accel()
		{
			speed += 10;
			if (speed > 120)
			{
				speed = 120;
			}
			Console.WriteLine($"차가 가속하여 {speed}가 되었습니다.");
		}

		public void Brake()
		{
			speed -= 10;
			if (speed < 0)
			{
				speed = 0;
			}
			Console.WriteLine($"차가 감속하여 {speed}가 되었습니다.");
		}
	}
}