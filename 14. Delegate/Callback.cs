using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
	internal class Callback
	{
		/*******************************************************************************
         * 콜백함수
         * 
         * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
         * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
         *******************************************************************************/

		public class Button1
		{
			public virtual void Click()
			{

			}

		}

		public class AttackButton : Button1
		{
			public override void Click()
			{
				// 공격하기
			}
		}

		public class JumpButton : Button1
		{
			public override void Click()
			{
				// 점프하기
			}
		}

		// 너무 길어~~



		public class Player
		{
			public void Jump() { Console.WriteLine("플레이어가 점프함"); }
			public void Dash() { Console.WriteLine("플레이어가 대시함"); }
		}

		public class Button
		{
			// OnClick : 함수를 담는 변수
			public Action OnClick; // 대리자(델리게이트)를 이용하여 호출하자!
								   // Action이 <> 없이 쓰는 이유는? 매개변수가 없어서!!!
								   // func도 <>에 반환값만 써도 된다. 매개변수 없이~~!!
								   // public Action OnClick = 공격();
			public virtual void Click()
			{
				// 공격(); 과 동일
				// delegate 쓸때는 안전하게 null 체크를 꼭 해주자.. 그게 국룰...ㅋ
				if (OnClick != null) // null : 가리키고 있는 것이 없다
					OnClick();
			}
		}

		static void Main1()
		{
			Player player = new Player();
			player.Jump(); // 콜 방식

			Button jumpButton = new Button(); // 점프 버튼 만들기
			jumpButton.OnClick = player.Jump; // 점프버튼을 눌렀을때 플레이어가 점프했으면 좋겠다.

			Button dashButton = new Button();
			dashButton.OnClick = player.Dash; // ()는 실행한다는 것, ()를 안붙이면 그 함수 자체를 넣는 것.

			jumpButton.Click(); // 점프버튼 클릭하면 점프한다! Click() 실행하면 OnClick 실행한다.

			dashButton.Click();

			// 지금까지는 원하는 타이밍에 호출을 했지만
			// 언제 버튼이 눌릴지 모르니까 호출을 당하는 것. 콜백과 지금까지 호출과의 차이
			// 언제 어떤 상황, 특정 조건에서 반응하는 함수를 구현할 수 있다.
		}

	}
}
