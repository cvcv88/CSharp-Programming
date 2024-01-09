using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
	internal class Property
	{
		public class Player
		{
			// <Getter Setter>
			// 맴버변수가 외부객체와 상호작용하는 경우 Get & Set 함수를 구현해 주는 것이 일반적
			// 1. Get & Set 함수의 접근제한자를 설정하여 외부에서 맴버변수의 접근을 캡슐화함
			// 2. Get & Set 함수를 거쳐 맴버변수에 접근할 경우 호출스택에 함수가 추가되어 변경시점을 확인 가능
			private int hp;     // 확인은 가능하게, 수정은 안되게 / 확인 OK, 수정 NO

			// 객체지향에서는 변수를 그냥 설정하지 않고, get set 함수로 설정해주는 것이 일반적
			public int GetHP() // 읽기, 확인
			{
				return hp;
			}

			private void SetHP(int hp) // 수정
			{
				if (hp < 0 || hp > 99999)
					Console.WriteLine("의도하지 않은 사용방법");
				this.hp = hp;
			}
			// 함수 둘 다 public이면 hp도 public, 함수 둘 다 private이면 hp도 private하면 되는거 아닌가?
			// 만약 이상한 hp를 대입했다면, 어디서 체력이 잘못되었는지 확인불가
			// hp는 private으로 하고 함수들만 public 했을때 sethp로만 설정가능하게하면
			// 어디서 값이 이상해졌는지 바로 확인가능
			// -> 오류 수정 방면에서 좋다. 디버깅 방면에서 좋다




			// <속성 (Property)>
			// Get & Set 함수의 선언을 간소화
			public event Action<int> OnChangeMp; // mp가 바뀔 때마다 이벤트 발생, 변경
			private int mp;
			public int Mp                       // mp 맴버변수의 Get & Set 속성, 프로퍼티는 대부분 대문자로 시작
			{
				get { return mp; }              // get : Get함수와 역할동일
				set { mp = value; OnChangeMp(mp); }  // set : Set함수와 역할동일, 매개변수는 value

			}



			public int Ap { get; set; }         // AP 맴버변수를 선언과 동시에 Get & Set 속성
			public int Dp { get; private set; } // 속성의 접근제한자를 통한 캡슐화
			public int Sp { get; } = 10;        // 읽기전용 속성(상수처럼 사용가능), 그냥 상수를 쓰자
			public int Hp => GetHP();           // 읽기전용 속성(람다처럼 사용가능)

			void Main()
			{
				Player player = new Player();
				int playerHp = player.GetHP(); // 외부에서 HP 확인하기
											   //player.SetHP(-100);
											   //player.SetHP(1); // SetHP가 private이므로 설정 불가

				int playerMp = player.Mp;
				player.Mp = 10;

				int playerHP = player.GetHP();
				// player.SetHP(10);            // error : SetHP는 private로 Player의 hp는 외부에서 변경불가

				int playerMP = player.Mp;       // 프로퍼티를 이용한 mp get 접근
				player.Mp = 20;                 // 프로퍼티를 이용한 mp set 접근

				int playerAP = player.Ap;       // 프로퍼티를 이용한 AP get 접근
				player.Ap = 20;                 // 프로퍼티를 이용한 AP set 접근

				int playerDP = player.Dp;       // 프로퍼티를 이용한 DP get 접근
												// player.DP = 20;              // error : DP의 set은 private로 외부에서 변경불가

				int playerSP = player.Sp;       // 프로퍼티를 이용한 SP get 접근
												// player.SP = 30;              // error : SP는 set이 없어 변경불가

			}
		}
	}
}
