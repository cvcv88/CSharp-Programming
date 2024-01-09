using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
	internal class Yield // in, out refence paramater, property, yield 기억해두기 !!!!
	{
		// <yield>
		// 반복기를 통해 데이터 집합을 하나씩 리턴할 때 사용
		// 1. 반환할 데이터의 양이 커서 한꺼번에 반환하는 것보다 분할해서 반환하는 것이 효율적인 경우(분산처리)
		// 2. 함수가 무제한의 데이터를 리턴할 경우
		// 3. 이전단계까지의 결과에서 다음까지만의 계산이 필요한 경우

		// 처음부터 Yield 호출이 된 부분까지만 실행하고
		// 전에 단계에서 끊긴 부분부터 다시 시작하는 것. 처음부터 끝까지 하는 것 x
		public static IEnumerable<int> GetNumber()
		{
			yield return 10;
			yield return 20;
			yield return 30;
			yield return 40;
			yield return 50;
		}
		public static void Main()
		{
			// foreach 반복문은 IEnumerable 인터페이스가 포함된 데이터 집합을 반복하는 방식
			foreach (int num in GetNumber())
			{
				Console.WriteLine(num);     // output : 10, 20, 30, 40, 50
			}
		}
		// <yield 형식>
		// yield return : 반복에서 다음을 제공
		IEnumerable<int> Repeater(int count)
		{
			for (int i = 0; i < count; i++)
			{
				yield return i;
			}
		}

		// yield break : 반복에서 끝을 제공
		IEnumerable<int> UntilPlus(IEnumerable<int> numbers)
		{
			foreach (int n in numbers)
			{
				if (n > 0)
					yield return n;
				else
					yield break;
			}
		}

		void Main2()
		{
			foreach (int num in Repeater(5))
				Console.WriteLine(num);     // output : 0, 1, 2, 3, 4

			foreach (int num in UntilPlus(new int[5] { 1, 3, 5, -1, 4 }))
				Console.WriteLine(num);     // output : 1, 3, 5
		}
	}
}
