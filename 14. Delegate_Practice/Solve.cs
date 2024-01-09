using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _14._Delegate_Practice1.Program.Calculator;

namespace _14._Delegate_Practice
{
	internal class Solve
	{
		public class Calculator
		{
			public static double Plus(double left, double right) { return left + right; }
			public static double Minus(double left, double right) { return left - right; }
			public static double Multi(double left, double right) { return left * right; }
			public static double Div(double left, double right) { return left / right; }

			double left;
			double right;
			Func<double, double, double> calc;

			//public delegate double Delegate(double left, double right);
			//Delegate delegate1;

			public void SetCommand(double left, char oper, double right)
			{
				// 계산금지
				this.left = left;
				this.right = right;

				switch (oper)
				{
					case '+':
						this.calc = Plus;
						break;
					case '-':
						this.calc = Minus;
						break;
					case '*':
						this.calc = Multi;
						break;
					case '/':
						this.calc = Div;
						break;
				}
			}

			public double Equal()
			{
				// 조건문 쓰기 금지
				return calc(left, right);
			}
		}

		public static void Main()
		{
			Calculator cal = new Calculator();
			cal.SetCommand(2.5, '+', 3.2);
			double result = cal.Equal();
			Console.WriteLine(result);
			// 결과가 5.7이 나오도록 구현
		}

	}
}
