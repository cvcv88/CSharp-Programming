using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace _09._OOP_Practice
{
	internal class Program
	{
		/*
		 * 1. 객체지향 프로그래밍 다루기
			드라이버, 차 클래스 객체 생성
			드라이버 <-> 차
			가속, 감속
			차의 속도 변화

		  2. 캡슐화 : 몬스터를 정의
			몬스터에 이름, 체력, 데미지 받기

		  3. 상속 : 여러 몬스터 종류 생성
			오크, 슬라임, 드래곤
			오크 : 분노
			슬라임 : 분열
			드래곤 : 브레스

			A+)제일 좋아하는 게임
			객체들을 설계
			캡슐화, 상속
		*/

		public class Driver
		{
			public string name;
			public void Ride(Vehicle vehicle)
			{
				Console.WriteLine($"{name} 이/가 {vehicle.name} 을/를 운전합니다.");
			}
			public void PushExcel(Vehicle vehicle)
			{
				vehicle.Move();
				Console.WriteLine("앞으로 나가자~");
			}
			public void PushBreak(Vehicle vehicle)
			{
				vehicle.Stop();
				Console.WriteLine("워~워~");
			}
		}
		public class Vehicle
		{
			public int speed = 0;
			public string name;
			public void Move()
			{
				speed += 10;
			}
			public void Stop()
			{
				speed = 0;
			}
		}
		static void Main1(string[] args)
		{
			Driver driver = new Driver() { name = "내" };
			Vehicle vehicle = new Vehicle() { name = "자동차" };

			driver.PushExcel(vehicle);
			driver.PushBreak(vehicle);
		}

		public class BestDriver
		{
			public string name;

			public void Ride(MyCar mycar)
			{
				Console.WriteLine($"{name} 이/가 {mycar.name} 을/를 운전합니다~");
				mycar.Move();
			}
			public void Stop(MyCar mycar)
			{
				Console.WriteLine($"{name} 이/가 {mycar.name} 의 운행을 멈춥니다~");
				mycar.Stop();
			}
		}
		public class MyCar
		{
			public string name;
			public int speed = 0;
			public void Move()
			{
				speed += 10;
				Console.WriteLine($"{name} 의 속도는 {speed}입니다욧!");
			}
			public void Stop()
			{
				speed = 0;
				Console.WriteLine($"{name} 의 속도는 {speed}입니다욧!");
			}
		}
		static void Main2(string[] args)
		{
			BestDriver bestdriver = new BestDriver() { name = "유정" };
			MyCar mycar = new MyCar() { name = "자동차" };

			bestdriver.Ride(mycar);
			bestdriver.Ride(mycar);
			bestdriver.Stop(mycar);
		}

		public class Slime
		{
			public string name = "Slime";
			int damage = 5;
			int hp = 50;

			public void TakeHit_Slime()
			{
				hp -= 10;
				Console.WriteLine($"{this.name}의 체력이 {hp} 이/가 되었습니다! 야호~");
				Console.WriteLine();
			}

			public void Attack(Player player)
			{
				Console.WriteLine($"{this.name} 이/가 {player.name} 에게 {this.damage} 의 데미지를 주었습니다..");
				player.TakeHit_Player();
			}
		}
		public class Player
		{
			public string name = "유정";
			int damage = 10;
			int hp = 30;

			public void TakeHit_Player()
			{
				hp -= 5;
				Console.WriteLine($"{this.name}의 체력이 {hp} 이/가 되었습니다.. 엉엉");
				Console.WriteLine();

			}
			public void Attack(Slime slime)
			{
				Console.WriteLine($"{this.name} 이/가 {slime.name} 에게 {this.damage} 의 데미지를 주었습니다!");
				slime.TakeHit_Slime();
			}

		}
		static void Main3(string[] args)
		{
			Slime slime = new Slime();
			Player player = new Player();

			player.Attack(slime);
			slime.Attack(player);
		}


		public class Monster
		{
			protected string name;
			protected int attack;

			public void Move()
			{
				Console.WriteLine($"{name} 이/가 움직입니다! ");
			}

			public void Attack()
			{
				Console.WriteLine($"{name} 이/가 {attack} 의 데미지의 공격을 했습니다.");
			}
		}
		public class Dragon : Monster
		{
			public Dragon()
			{
				name = "지드래곤";
				attack = 10;
			}

			public void Breath()
			{
				Console.WriteLine($"{name} 이/가 브레스 공격을 합니다.");
			}
		}
		public class Slime1 : Monster
		{
			public Slime1()
			{
				name = "슬라임1";
				attack = 3;
			}

			public void Split()
			{
				Console.WriteLine($"{name} 이/가 분열합니다.");
			}
		}
		public class Ock : Monster
		{
			public Ock()
			{
				name = "5크";
				attack = 7;
			}

			public void Rage()
			{
				Console.WriteLine($"{name} 이/가 분노했습니다!");
			}
		}
		static void Main4(string[] args)
		{
			Dragon dragon = new Dragon();
			Slime1 slime1 = new Slime1();
			Ock ock = new Ock();

			dragon.Attack();
			slime1.Attack();
			ock.Attack();

			Console.WriteLine();

			dragon.Breath();
			slime1.Split();
			ock.Rage();
		}
	}
}