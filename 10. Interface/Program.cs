namespace _10._Interface
{
	internal class Program
	{
		/* * * * * * *  
		 * 인터페이스 (Interface) : 어떻게 상호작용할 것인지 정의해놓은 것.
		 * UI : User Interface, 게임이랑 유저가 상호작용할 수 있도록 도와주는 것
		 * Interface : a랑 b랑 상호작용할 때 도와주는 것.
         * 
         * 인터페이스는 맴버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
         * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함
         * 상속과 인터페이스를 동시에 사용 가능하지만 상속이 맨 앞에 와야한다.
		 * * * * * * */

		// <인터페이스 정의>
		// 일반적으로 인터페이스의 이름은 I로 시작함
		// 인터페이스의 함수는 직접 구현하지 않고 정의만 진행

		public interface IEnterable
		{
			public void Enter();
		}

		public interface IOpenable
		{
			public void Open();
		}


		// <인터페이스 포함>
		// 상속처럼 정의한 인터페이스를 클래스 : 뒤에 선언하여 사용
		// 인터페이스를 포함하는 경우 반드시 인터페이스에서 정의한 함수를 구현해야 함
		// 인터페이스는 여러개 포함 가능

		/*		public class IOpenable
				{
					public virtual void Open()
					{
						Console.WriteLine("열립니다.");
					}
					public virtual void Close()
					{

					}
				}

				public class IEnterable
				{
					public virtual void Enter()
					{
						Console.WriteLine("들어갑니다.");
						// 기타 등등 기능 ...
					}
				}*/

		public class Box : IOpenable, IDamagalbe
		{
			public void Open()
			{
				Console.WriteLine("박스를 엽니다.");
				Console.WriteLine("아이템이 온전하게 나옵니다");
			}
			public void TakeHit(int damage)
			{
				Console.WriteLine("아이템이 내구도가 닳아서 나왔습니다.");
			}
		}
		public class Door : IOpenable, IEnterable, IDamagalbe // 한번에 두 인터페이스 가능
		{
			public void Open()
			{
				Console.WriteLine("문을 엽니다."); ;
			}
			public void Enter()
			{
				Console.WriteLine("문에 들어갑니다"); ;
			}
			public void TakeHit(int damage)
			{
				Console.WriteLine("문을 부셨다.");
			}
		}

		public class Town : IEnterable
		{
			public void Enter()
			{
				Console.WriteLine("마을에 진입합니다.");
			}
		}

		public interface IDamagalbe
		{
			public void TakeHit(int damage);
		}


		// <인터페이스 사용>
		// 인터페이스를 이용하여 기능을 구현할 경우
		// 클래스의 상속관계와 무관하게 행동의 가능여부로 상호작용 가능
		public class Player
		{
			public void Open(IOpenable openable)
			{
				Console.WriteLine("플레이어가 대상을 열기 시도합니다.");
				openable.Open();
			}
			public void Enter(IEnterable enterable)
			{
				Console.WriteLine("플레이어가 대상에 들어가기 시도합니다.");
				enterable.Enter();
			}
			public void Attack(IDamagalbe damagable)
			{
				Console.WriteLine("플레이어가 대상을 공격하기 시도합니다.");
				damagable.TakeHit(10);
			}
		}
		public class Monster : IDamagalbe
		{
			public int hp;
			public void TakeHit(int damage)
			{
				hp -= damage;
				Console.WriteLine("몬스터가 데미지를 받았다.");
			}
		}

		static void Main(string[] args)
		{
			Player player = new Player();
			Box box = new Box();
			Town town = new Town();

			player.Open(box);
			player.Enter(town);

			Door door = new Door();

			player.Open(door);
			player.Enter(door);

			Monster monster = new Monster();
			player.Attack(monster);
			player.Attack(door);
			player.Attack(box);
		}
	}
}