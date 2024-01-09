using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
	internal class Polymorphism
	{
		/* * * * * * *  
		 * 다형성 (Polymorphism)
         *
         * 객체의 속성이나 기능이 상황에 따라 여러가지 형태를 가질 수 있는 성질
		 * * * * * * */

		// <다형성>
		// 부모클래스의 멤버를 자식클래스가 상황에 따라 여러가지 형태를 가질 수 있는 성질
		// 동일한 부모클래스를 상속받아도 자식클래스에서 각각 다른 반응을 보이는 것.(수치, 데이터 등)
		// 몬스터가 공격받았을 때 몬스터 종류마다 다르게 반응하는것(상속과 아주 유사함)
		class Car
		{
			protected string name;
			protected int speed;

			public void Move()
			{
				Console.WriteLine($"{name} 이/가 {speed} 의 속도로 이동합니다.");
			}
		}

		class Truck : Car
		{
			public Truck()
			{
				name = "트럭";
				speed = 30;
			}
		}

		class SportCar : Car
		{
			public SportCar()
			{
				name = "스포츠카";
				speed = 100;
			}
		}

		void Main1()
		{
			Car car1 = new Truck();
			Car car2 = new SportCar();

			car1.Move();    // 트럭 이/가 30 의 속도로 이동합니다.
			car2.Move();    // 스포츠카 이/가 100 의 속도로 이동합니다.
		}


		// 함수(기능)는 조금 다르다.
		// <가상함수와 오버라이딩>
		// 가상함수   : 부모클래스의 함수 중 자식클래스에 의해 재정의 할 수 있는 함수를 지정
		// virtual 함수, 부모 클래스에 virtual을 붙여서 재정의한다. 재정의 허용해준다는 표시.

		// 오버라이딩 : 부모클래스의 가상함수를 같은 함수이름과 같은 매개변수로 재정의하여 자식만의 반응을 구현
		// override, 가상함수가 아닌 함수를 오버라이드 할 수 없고,
		// 가상함수가 맞다면 그 함수를 대신해서 내 함수를 덮어씌운다.

		// virtual - override 는 세트

		// 원리(CS 지식) 가상함수 테이블

		class Skill
		{
			protected float coolTime;
			public virtual void Execute()       // 가상함수 virtual 함수
			{
				Console.WriteLine("스킬 재사용 대기시간을 진행시킴");
			}
		}

		class FireBall : Skill
		{
			public FireBall()
			{
				coolTime = 3f;
			}
			public override void Execute()      // 오버라이딩 override, 재정의, 덮어쓴다.
			{
				base.Execute();      // base : 부모클래스를 가리킴
									 //Console.WriteLine("스킬 재사용 대기시간을 진행시킴");
				Console.WriteLine("전방에 화염구를 날림");
			}
		}

		class Heal1 : Skill
		{
			public Heal1()
			{
				coolTime = 15f;
			}
			public override void Execute()
			{
				base.Execute();
				// Console.WriteLine("스킬 재사용 대기시간을 진행시킴");
				Console.WriteLine("상처를 치료한다.");
			}

		}

		static void Main2()
		{
			Skill fireBall = new FireBall();
			fireBall.Execute();     // 자식클래스의 함수가 호출됨
									// 스킬 재사용 대기시간을 진행시킴
									// 전방에 화명구를 날림

			Skill heal = new Heal1();
			heal.Execute();

			Console.WriteLine();
			// 왜 위아래 결과가 다를까?
			// 위는 fireBall과 heal이 Skill로 만들어졌고, 각 자식클래스가 override 하지 않은 상태여서
			// Skill의 execute가 실행되었다.

			// 아래는 fireBall과 heal이 각 상속 자식 클래스로 만들어졌기때문에 override 하지 않아도
			// 각 FireBall.Execute(), Heal.Execute()가 실행된다!!!
			// 그러나 아래같은 상황은 잘 쓰지 않는다. 자식이 온갖 스킬을 가지고 있어야 하기 때문에.
			/* 내가 지금 아직 어떤 캐릭터를 선택할지 모르는 상황에서 player는 일단 스킬을 쓴다라는 기능을
			 * 만들어야한다. 근데 그 과정에서 내가 특정 한 스킬로 스킬을 저장한다면, 나는 계속 그 스킬밖에
			 * 쓰지 못할것!! 그렇기 때문에 스킬이라는 큰 틀을 우선 잡고나서 virtual override로 세부적으로
			 * 들어가는 것이다
			 * 아니면 abstract 추상화로 일단 UseSkill 만들어놓고나서 아래에서 무조건 세부조건 설정하게
			 * 할수도 있음~~~!!!
			 */

			FireBall fireBall1 = new FireBall();
			fireBall1.Execute();

			Heal heal1 = new Heal();
			heal1.Execute();
		}


		// <다형성 사용의미 1>
		// 새로운 클래스를 추가하거나 확장할 때 기존 코드에 영향을 최소화함

		// 플레이어에 skill을 넣어두었기때문에 새로운 skill이 생겨도 문제없다.
		// 어렵땅
		class Player
		{
			Skill skill;

			public void SetSkill(Skill skill)
			{
				this.skill = skill;
			}

			public void UseSkill()
			{
				skill.Execute();
			}
		}

		class Heal : Skill      // 새로운 클래스를 만들 때 기존의 소스를 수정하지 않아도 됨
		{
			public override void Execute()
			{
				base.Execute();
				Console.WriteLine("아군의 체력을 회복함");
			}
		}


		// <다형성 사용의미 2>
		// 클래스 간의 의존성을 줄여 확장성은 높임
		class SkillContents : Skill { }     // 프로그램의 확장을 위해 상위클래스를 상속하는 클래스를 개발


	}
}
