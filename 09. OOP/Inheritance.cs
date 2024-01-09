using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
	public class Inheritance
	{
		/* * * * * * *  
		 * 상속 (Inheritance)
         *
         * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
         * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
		 * * * * * * */

		// <상속>
		// 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
		// class 자식클래스이름 : 부모클래스이름

		public class Monster
		{
			public string name;
			public int hp;

			public Monster()
			{
				Console.WriteLine("몬스터 생성자");
			}

			public void Move()
			{
				Console.WriteLine($"{name} 이/가 움직입니다.");
			}

			public void Die()
			{
				// 경험치 떨어뜨리기
			}

			public void TakeHit(int damage)
			{
				hp -= damage;
				Console.WriteLine($"{name} 이/가 데미지를 받아 체력이 {hp} 가 되었습니다.");
			}
		}
		public class Dragon : Monster
		{
			public Dragon()
			{
				Console.WriteLine("드래곤 생성자");
				name = "지드래곤";
				hp = 100;
			}

			public void Breath()
			{
				Console.WriteLine($"{name} 이/가 브레스를 뿜습니다.");
			}

			public void Reflect()
			{
				Console.WriteLine("반격");
			}
		}

		public class Slime : Monster
		{
			public Slime()
			{
				name = "슬라임";
				hp = 25;
			}
			public void Split()
			{
				Console.WriteLine($"{name} 이/가 분열합니다.");
			}
		}

		public class Orc : Monster
		{
			public Orc()
			{
				name = "오크";
				hp = 50;
			}
			public void Rage()
			{
				Console.WriteLine($"{name} 이/가 분노합니다.");
			}
		}

		public class AttackRange : Monster
		{
			public float range;
			// 마우스 클릭 구현
			public void SetTarget()
			{

			}
		}

		public class Hero
		{
			int damage = 3;

			// 상속 하지 않았을 때는 몬스터 새로 생길때마다 만들어줘야 한다..
			/*public void Attack(Dragon dragon){ }
			 *public void Attack(Slime slime){ }
			 *public void Attack(Orc orc){ }
			*/

			// 부모클래스를 매개변수로 주면서 자식클래스까지 같이 포함시킨다. = 업캐스팅
			public void Attack(Monster monster)
			{
				monster.TakeHit(damage);

				// 드래곤이면 반격도 해야함 (다운캐스팅 사용하는 예제)
				if (monster is Dragon)
				{
					Dragon dragon = (Dragon)monster;
					dragon.Reflect();
				}
			}
		}
		public static void Main1(string[] args)
		{
			Dragon dragon = new Dragon();
			dragon.TakeHit(10);
			dragon.Breath();

			// Main에서 초기화할 떄 형태
			/*dragon.name = "용";
			dragon.hp = 100;*/

			Slime slime = new Slime();
			slime.TakeHit(10);
			slime.Split();

			Orc orc = new Orc();
			orc.TakeHit(10);
			orc.Rage();

			Console.WriteLine();

			// 업캐스팅 : 자식클래스는 부모클래스 자료형으로 묵시적 형변환 가능
			// 자식클래스를 부모클래스에 보관(묵시적)
			// Monster monster이지만 자식클래스가 부모클래스 자료형으로 자동적으로 형변환된다.
			// 자식클래스가 부모클래스의 자료형으로 묵시적 형변환이 되면서, 부모의 기능을 사용할 수 있는것.
			// 반대로 부모클래스 변수 = new 자식클래스();일때 자식클래스의 기능은 수행불가다!

			Hero hero = new Hero();
			hero.Attack(dragon);
			hero.Attack(slime);
			hero.Attack(orc);

			Console.WriteLine();

			Monster monster1 = new Dragon();
			Monster monster2 = new Slime();

			monster1.TakeHit(10); ;
			// monster1.Breath();	// error, 자식만의 기능은 수행불가, 다운캐스팅 필요

			monster2.TakeHit(10); ;
			// monster2.spilt();	// error

			Console.WriteLine();

			// 다운캐스팅
			// 부모클래스를 자식클래스에 보관(명시적)
			Dragon dra = (Dragon)monster1; // 100% 인 경우에만 진행(명시적) , 오류는 아님
										   // 업캐스팅한 객체를 다시 자식 클래스 타입의 객체로 되돌리는 것을 목적으로 한다.(복구)
										   // 위에서 Monster monster1 = new Dradon();으로 선언했기에 monster1을 (Dragon)으로 형변환 가능.
										   // 형변환이 가능하다는게 100%면 사용해도 되지만,, 혹시모르니 아래 방법 쓰기.

			// Slime sli = (Slime)monster1; // 형변환이 불가능한 경우 오류

			if (monster1 is Dragon) // 인스턴스(monster1)가 dragon인지 is 키워드 사용
			{
				Console.WriteLine("monster1은 지드래곤입니다.");
				Dragon d = (Dragon)monster1;
			}
			else
			{
				Console.WriteLine("monster1은 지드래곤이 아닙니다.");
			}

			if (monster2 is Dragon) // 인스턴스(monster2)가 dragon인지
			{
				Console.WriteLine("monster2는 지드래곤입니다.");
				Dragon d = (Dragon)monster2;
			}
			else
			{
				Console.WriteLine("monster2은 지드래곤이 아닙니다.");
			}

			// as : 형변환이 가능하면 바로 바꿔주고, 불가능하면 null 반환.
			Dragon asDragon = monster1 as Dragon;
			Slime asSlime = monster2 as Slime;
		}


		// <상속 사용의미 1>
		// 상속을 진행하는 경우 부모클래스의 소스가 자식클래스에서 모두 적용됨
		// 부모클래스와 자식클래스의 상속관계가 적합한 경우,
		// 부모클래스에서의 기능 구현이 자식클래스에서도 어울림
		class Fruit
		{
			// 부모클래스에서 기능을 구현할 경우 모든 부모를 상속하는 자식클래스에 기능을 구현하는 효과
		}

		class Apple : Fruit
		{
			// 자식클래스에서 자식클래스만의 기능을 구현
		}


		// <상속 사용의미 2>
		// 업캐스팅을 통해 자식클래스는 부모클래스로 형변환이 가능함
		// 자식클래스는 부모클래스를 요구하는 곳에서 동일한 기능을 수행할 수 있음
		class Parent
		{
			public void Func() { }
		}
		class Child1 : Parent { }
		class Child2 : Parent { }
		class Child3 : Parent { }

		void UseParent(Parent parent) { parent.Func(); }
		void Main2()
		{
			Child1 child1 = new Child1();
			Child2 child2 = new Child2();
			Child3 child3 = new Child3();

			UseParent(child1);
			UseParent(child2);
			UseParent(child3);
		}
	}
}


