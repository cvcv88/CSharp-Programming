using System.Dynamic;

namespace _15._Event
{
	internal class Program
	{
		/****************************************************************
         * 이벤트 (Event) : 델리게이트로 만들어지지만 문제점 보완한 것, 콜백함수의 일종
         * 다른점? 콜백은 하나의 대상에 대해서 참조, 이벤트는 여러 대상에게 알려주는 것
         * 델리게이트 체인을 통해서 이벤트 구현할 수 있음.
         * 
         * 일련의 사건이 발생했다는 사실을 다른 객체에게 전달
         * ex) 플레이어가 맞았다면 : 체력바 줄어들기, 피격음 재생, 이펙트 보여주기, 게임 스코어 깎기 등..
         * 
         * 콜백을 여러 대상에게 전달하는 것과 동일, 델리게이트 체인과 유사
         * 델리게이트의 일부 기능을 제한하여 이벤트의 용도로 사용
         ****************************************************************/

		// <이벤트 선언>
		// 델리게이트 변수 앞에 event 키워드를 추가하여 이벤트로 선언

		public class Player()
		{
			public event Action OnGetCoin; // 코인 먹는 이벤트
			public event Action OnDamaged; // 데미지 받는 이벤트
										   // 이벤트의 목적으로만 사용할 수 있다. 수단으로 사용 불가 OnGetCoin(); 사용 불가라는 뜻


			public Action OnDied; // 델리게이트

			private void Die()
			{
				if (OnDied != null) OnDied();
			}

			public void GetCoin()
			{
				Console.WriteLine("플레이어가 코인을 획득함");

				if (OnGetCoin != null)
					OnGetCoin(); // 사건이 발생했을 때 이벤트 발생시키자.
			}

			public void GetDamage()
			{
				Console.WriteLine("플레이어가 데미지를 받음");

				if (OnDamaged != null)
					OnDamaged(); // 일련의 사건이 발생했을 때 이벤트 발생
			}
		}

		public class UI
		{
			public void CoinUI() { Console.WriteLine("UI에 코인수를 갱신"); }
		}

		public class SFX
		{
			public void CoinSound() { Console.WriteLine("코인을 얻는 효과음 재생"); }
		}

		public class VFX
		{
			public void CoinEffect() { Console.WriteLine("코인을 얻는 반짝거리는 효과"); }
		}


		// <이벤트 등록 & 해제>
		// 이벤트에 반응할 객체의 추가할 함수를 += 연산자를 통해 참조 추가
		// 이벤트에 반응할 객체의 제거할 함수를 -= 연산자를 통해 참조 제거

		// 대리자(델리게이트, Delegate)를 통해 함수를 담을 수 있는 변수를 만들고,
		// 하나의 동작에 연달에 자동으로 따라오는 다양한 함수들을 저장한다.
		// 그럼 하나의 델리게이트 변수에 여러 함수들이 저장된다.
		// -> 델리게이트 체인(이벤트)의 기본 동작 방식

		static void Main(string[] args)
		{
			Player player = new Player();
			UI ui = new UI();
			SFX sfx = new SFX();
			VFX vfx = new VFX();

			// 이벤트에 반응할 객체의 함수 추가
			player.OnGetCoin += ui.CoinUI;
			player.OnGetCoin += sfx.CoinSound;

			// 일련의 사건이 발생했을 때 이벤트를 통한 반응
			player.GetCoin();
			// 플레이어가 코인을 얻음
			// UI에 코인수를 갱신
			// 코인을 얻는 효과음 재생


			// 이벤트 방식으로 코드 수정없이 이벤트시 반응할 객체를 추가 가능
			player.OnGetCoin += vfx.CoinEffect;
			Console.WriteLine();
			player.GetCoin();
			// 플레이어가 코인을 얻음
			// UI에 코인수를 갱신
			// 코인을 얻는 효과음 재생
			// 코인을 얻는 반짝거리는 효과


			// 이벤트 방식으로 코드 수정없이 이벤트시 반응할 객체를 제거 가능
			player.OnGetCoin -= sfx.CoinSound;

			Console.WriteLine();
			player.GetCoin();
			// 플레이어가 코인을 얻음
			// UI에 코인수를 갱신
			// 코인을 얻는 반짝거리는 효과


			// 언제든지 OnGetCoin을 실행하면(이벤트 발생시) 모든 함수가 실행된다.



			// <문제점> 델리게이트를 이벤트로 쓸 때의 문제점
			// 1. 델리게이트 체인 = (대입) 가능 -> 손쉽게 초기화 가능
			//player.OnGetCoin = sfx.CoinSound;

			//Console.WriteLine();
			//player.GetCoin();
			// 플레이어가 코인을 얻음
			// 코인을 얻는 효과음 재생

			// 2. 이벤트 발생이 외부에서 가능
			//player.OnGetCoin(); // GetCoin 함수 실행이 아니라 그 안에 있는 OnGetCoin 함수 바로 실행

			//player.OnDied(); // 이런 상황도 가능.. 갑자기 죽었다!!

			// 실수를 안하려고 노력? 불가능.. 무리무리~ 실수할 수 없게 해야한다.
			// 문제점 1, 2 막아주는 것이 이벤트다!
			// event 붙이기 : 이 delegate는 event로 쓸것이다(이벤트 용도로만)
			// event 붙이면 문제점 1과 2가 불가능하게 막힘!!

			// OnDied를 private으로 하면 되는거 아니냐? 하면
			// 다른 이벤트를 추가하는 것도 안되기 때문에 public으로 해줘야 한다.
		}

		// <델리게이트 체인과 이벤트의 차이점>
		// 델리게이트 또한 체인을 통하여 이벤트로서 구현이 가능
		// 하지만 델리게이트는 두가지 사항 때문에 이벤트로서 사용하기 적합하지 않음
		// 1. = 대입연산을 통해 기존의 이벤트에 반응할 객체 상황이 초기화 될 수 있음
		// 2. 클래스 외부에서 이벤트를 발생시켜 원하지 않는 상황에서 이벤트 발생 가능
		// event 키워드를 추가할 경우 델리게이트에서 위 두가지 기능을 제한하여 이벤트 전용으로 사용을 유도할 수 있음
		// 즉, event 변수는 델리게이트에서 기능을 제한하여 이벤트 전용의 기능만으로 사용하는 기능

		public class EventSender
		{
			public Action OnDelegate;
			public event Action OnEvent;

			public void DelegateCall()
			{
				if (OnDelegate != null)
					OnDelegate();
			}

			public void EventCall()
			{
				if (OnEvent != null)
					OnEvent();
			}
		}

		public class EventListener
		{
			public void ReAction() { }
		}

		void Main2()
		{
			EventSender sender = new EventSender();
			EventListener listener1 = new EventListener();
			EventListener listener2 = new EventListener();
			EventListener listener3 = new EventListener();

			// 제한사항 1. 이벤트 변수는 = 대입연산 불가

			// 델리게이트는 대입연산이 가능하여, 이벤트에 반응할 객체들의 상황을 잃을 문제점이 있음
			sender.OnDelegate += listener1.ReAction;
			sender.OnDelegate += listener2.ReAction;
			sender.OnDelegate = listener3.ReAction;     // 주의! 기존의 이벤트에 반응할 객체들이 초기화됨

			// 이벤트는 대입연산이 불가하여, 이벤트에 반응할 객체들의 상황을 온전히 유지 가능
			sender.OnEvent += listener1.ReAction;
			sender.OnEvent += listener2.ReAction;
			// sender.OnEvent = listener3.ReAction;     // error : 이벤트는 = 대입연산 불가


			// 제한사항 2. 이벤트 변수는 클래스 외부에서 호출 불가

			// 델리게이트는 외부에서 호출이 가능하여, 객체가 일련의 사건이 발생하지 않아도 이벤트 발생이 진행될 문제점이 있음
			sender.OnDelegate();                        // 주의! 일련의 사건이 발생하지 않아도 이벤트 발생이 가능

			// 이벤트는 외부에서 호출이 불가하여, 객체가 일련의 사건이 발생한 경우에서만 내부에서 이벤트 발생 보장이 가능
			// sender.OnEvent();                        // error : 이벤트는 외부에서 호출 불가
		}


	}
}
