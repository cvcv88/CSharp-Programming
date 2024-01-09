using System.Security.Cryptography.X509Certificates;

namespace _14._Delegate_Practice1
{
	public class Program
	{
		public static double Add(double left, double right) { return left + right; }
		public static double Minus(double left, double right) { return left - right; }
		public static double Mult(double left, double right) { return left * right; }
		public static double Div(double left, double right) { return left / right; }

		public class Calculator
		{
			public delegate double Delegate(double left, double right);
			Delegate delegate1;

			public double left;
			public double right;

			public void SetCommand(double left, char oper, double right)
			{
				// 계산 금지
				this.left = left;
				this.right = right;
				switch (oper)
				{
					case '+':
						delegate1 = Add;
						break;
					case '-':
						delegate1 = Minus;
						break;
					case '*':
						delegate1 = Mult;
						break;
					case '/':
						delegate1 = Div;
						break;
				}
			}

			public double Equal()
			{
				// 조건문 쓰기 금지
				double result = delegate1(left, right);
				return result;
			}
		}
		static void Main1(string[] args)
		{
			Calculator cal = new Calculator();
			cal.SetCommand(2.5, '+', 3.2);
			double result = cal.Equal();
			Console.WriteLine(result);
		}

	}
}