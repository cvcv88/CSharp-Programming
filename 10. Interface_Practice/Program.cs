namespace _10._Interface_Practice
{
	public class Program
	{
		/*
		    플레이어 : 물체를 여는 기능, 들어가는 기능
			상자, 문, 마을 
			문, 마을 : 들어갈 수 있어야 함
			문 들어갔을 때 : 건물안으로 들어간다.
			마을 들어갔을 때 : 마을 맵을 진입한다.
			상자, 문 : 열수 있어야 함
			상자를 열면 : 아이템 나오게
			문을 열면 : 진입할 수 있도록 설명한다.

			탑승물 : 탈수 있어야 한다. 열어야지 탈수 있다.

			A++) IComparable 인터페이스 (구글링, MSDN, StackOverflow)
 			Item class를 IComparable 붙여서
			Item[] inventory = new Item[5]; 배열이 있으면
			이름순으로 정렬시키기 구현 해보기
		 */

		public interface IOpenable
		{
			public void Open();
		}

		public interface IEnterable
		{
			public void Enter();
		}

		public interface IRidable
		{
			public void Ride();
		}
		public class Player
		{
			public void Open(IOpenable openable)
			{
				Console.WriteLine("플레이어가 대상을 열려고 시도합니다.");
				openable.Open();
			}
			public void Enter(IEnterable enterable)
			{
				Console.WriteLine("플레이어가 대상에 접근하려고 합니다.");
				enterable.Enter();
			}
			public void Ride(IRidable ridable)
			{
				Console.WriteLine("플레이어가 대상을 타려고 합니다.");
				ridable.Ride();
			}
		}

		public class Box : IOpenable
		{
			public void Open()
			{
				Console.WriteLine("박스를 엽니다");
				Console.WriteLine("아이템이 나왔습니다.");
				Console.WriteLine();
			}
		}

		public class Door : IOpenable, IEnterable
		{
			public void Open()
			{
				Console.WriteLine("문을 엽니다.");
				Console.WriteLine();
			}
			public void Enter()
			{
				Console.WriteLine("문으로 들어갑니다.");
				Console.WriteLine("건물 안으로 입장합니다.");
				Console.WriteLine();
			}
		}

		public class Town : IEnterable
		{
			public void Enter()
			{
				Console.WriteLine("마을로 들어갑니다");
				Console.WriteLine();
			}
		}

		public class Vehicle : IOpenable, IRidable
		{
			public void Open()
			{
				Console.WriteLine("자동차 문을 엽니다.");
				Console.WriteLine();
			}

			public void Ride()
			{
				Console.WriteLine("자동차에 탑승합니다.");
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			Player player = new Player();
			Box box = new Box();
			Door door = new Door();
			Town town = new Town();

			player.Open(box);
			player.Open(door);
			player.Enter(door);

			player.Enter(town);

			Vehicle vehicle = new Vehicle();
			player.Open(vehicle);
			player.Ride(vehicle);

		}
	}
}