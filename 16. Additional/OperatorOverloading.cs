using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
	internal class OperatorOverloading
	{
		/**********************************************************************
         * 연산자 재정의 (Operator Overloading)
         *
         * 사용자정의 자료형이나 클래스의 연산자를 재정의하여 여러 의미로 사용
         **********************************************************************/

		// <연산자 재정의>
		// 기본연산자의 연산을 함수로 재정의하여 기능을 구현
		// 기본연산자를 호환하지 않는 사용자정의 자료형에 기본연산자 사용을 구현함

		public struct Vector2
		{
			public int x;
			public int y;

			public Vector2(int x, int y)
			{
				this.x = x;
				this.y = y;
			}


			// 연산자 재정의를 통한 기본연산자 사용 구현
			public static Vector2 operator +(Vector2 a, Vector2 b)
			{
				int x = a.x + b.x;
				int y = a.y + b.y;

				return new Vector2(x, y);
			}

			public static Vector2 operator *(Vector2 vec, int value)
			{
				return new Vector2(vec.x * value, vec.y * value);
			}
		}
		void Main()
		{
			Vector2 avec2 = new Vector2(2, 1);
			Vector2 bvec2 = new Vector2(5, 3);

			// Vector2 resultVec = avec2 + bvec2; // 오류
			Vector2 resultVec1 = new Vector2(avec2.x + bvec2.x, avec2.y + bvec2.y); // 진짜 대박 귀찮~

			Vector2 resultVec2 = new Vector2(3, 3) + new Vector2(2, 5);        // point == (5, 8)

			// Point point = new Vector2(3, 3) - new Vector2(1, 2);     // error : - 기본연산자는 재정의되어 있지 않음
		}

	}
}
