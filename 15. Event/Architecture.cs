using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Event
{
	internal class Architecture
	{
		/****************************************************************
         * 이벤트의 사용의미
         * 
         * 이벤트를 사용할 경우 클래스의 개방폐쇄원칙을 지킬 수 있으며
         * 일련의 사건이 발생한 타이밍에만 연산을 진행할 수 있음
         ****************************************************************/

		// 각각의 방식 모두 적재적소에 쓸 수 있는 상황이 있다.
		// 체력이 30초만에 10 깎이고 10초 후에 20 회복되고 .. : 이벤트 적합
		// 위치는 실시간으로 계속 변화하고 있다. 변경사항이 계속해서 있으면 단점이 장점됨 : polling 적합
		// 유니티에서 Update()가 polling과 동일, 1초에 60번 실행..

		// call 은..? 사용 안함!!!!!

		public class Call
		{
			// <Call 방식>
			// 일련의 사건이 발생한 순간에 대상의 함수를 호출하여 진행
			// 장점 : 불필요한 연산 없이 일련의 사건이 발생한 타이밍에 처리 가능
			// 단점 : 추가 기능 개발시 클래스를 수정해야하는 ^개방폐쇄의 원칙^을 위반함

			// 새로운 기능 추가시 클래스 자체를 계속해서 수정해야함.
			// 함수를 직접적으로 호출해주는 방식

			public class Player
			{
				public int hp = 100;

				public UI ui;

				public void Hit(int damage)
				{
					hp -= damage;
					Console.WriteLine($"플레이어가 데미지를 받아 체력이 {hp} 이 되었습니다.");

					// 클래스에서 연관된 기능들을 직접 호출해야함
					// 만약 새로운 기능이 추가되는 경우 계속해서 수정될 부분
					ui.SetHP(hp);
				}
			}

			public class UI
			{
				public void SetHP(int hp)
				{
					Console.WriteLine($"UI의 체력표시를 {hp} 으로 변경합니다.");
				}
			}
		}

		public class Polling
		{
			// <Polling 방식>
			// 대상에서 일련의 사건 발생을 확인하기 위해 계속해서 변경사항을 확인
			// 장점 : 추가 기능 개발시에도 클래스를 수정하지 않아 개방폐쇄의 원칙을 준수함
			// 단점 : 변경사항이 없는 경우에도 계속 확인해야하는 불필요한 연산이 발생

			// player의 hit을 알려주지 않다보니 UI가 확인해야함.
			// player가 바뀌었는지 아닌지 계속계속 확인해야한다. 불필요한 행위 너무 많아짐

			// UI가 Player를 가르키자! UI가 체력깎인거 처리, UI가 Player에게 계속계속 물어봄.
			// Player 바뀌는거 없고, 새로 만드는 클래스들이 Player 갖게 하면서 개방폐쇄의 원칙 준수함
			// 그러나 너무나도 불필요하게 자주 체력을 확인한다. 어후~

			public class Player
			{
				public int hp = 100;

				public void Hit(int damage)
				{
					hp -= damage;
					Console.WriteLine($"플레이어가 데미지를 받아 체력이 {hp} 이 되었습니다.");
				}
			}

			public class UI
			{
				public Player player;

				// UI를 갱신하기 위해 주기적으로 실행해야함
				// 갱신이 늦을 경우 UI에서 확인하는 내용이 실제 데이터와 다를 수 있음
				public void CheckHP()
				{
					Console.WriteLine($"UI의 체력표시를 {player.hp} 으로 변경합니다.");
				}
			}


		}

		public class Event
		{
			// <Event 방식>
			// 일련의 사건이 발생했을 때 반응할 대상을 참조하고 사건 발생시 호출하여 진행
			// 장점 : 개방폐쇄의 원칙이 지켜지며, 불필요한 연산을 필요로 하지 않음
			// 단점 : 이벤트를 구성하기 위한 추가적인 소스를 작성해야 함, 붙여주는 작업 필요함.

			// 시간이 일정하지않고, 어떤 상황에 따라서 바뀔때 적합하다.
			// 실시간으로 자료의 변경이 빈번하면 polling(위치 등), 어쩌다 한번 변하거나, 특정 사건이 생겨서 변했을 때 event(점프 등)

			// -> 사전작업 필요. 
			// ex 위치 같은거는 이벤트 사용 x (계속해서 바뀌는 것들)

			public class Player
			{
				public int hp = 100;

				public event Action<int> OnChangeHP;

				public void Hit(int damage)
				{
					hp -= damage;
					Console.WriteLine($"플레이어가 데미지를 받아 체력이 {hp} 이 되었습니다.");

					// 사건이 발생한 시점에 이벤트를 등록한 객체들의 함수를 호출
					// 이벤트로 구성할 경우 새로운 기능이 추가되어도 수정할 필요가 없음
					if (OnChangeHP != null)
						OnChangeHP(hp);
				}
			}

			public class UI
			{
				// 이벤트 발생 시점에 호출당할 함수
				// 이벤트 발생 시점에 반드시 호출당하기 때문에 주기적인 실행이 필요없음
				public void SetHP(int hp)
				{
					Console.WriteLine($"UI의 체력표시를 {hp} 으로 변경합니다.");
				}
			}
		}

	}
}
