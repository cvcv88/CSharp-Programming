using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _06._UserDefineType
{
	internal class Program
	{
		// 사용자 정의형 자료

		/* * * * * * *  
		 * 열거형 (Enum)
		 * 
		 * 기본 정수 숫자의 형식의 명명된 상수 집합에 의해 정의되는 값 형식
		 * 열거형 멤버의 이름으로 관리되어 코드의 가독성, 관리 측면에 도움이 됨
		 * * * * * * */

		// <열거형 기본사용>
		// enum 열거형이름 { 멤버이름, 멤버이름, ... }
		enum Direction { Up, Down, Left, Right }

		enum EquipType { Head, Body, Arm, Foot, Ring }
		static void Main1(string[] args)
		{
			// 열거형을 사용하지 않을 때..
			// 0 : 위쪽, 1 : 아래쪽, 2 : 왼쪽, 3: 오른쪽
			int input1 = 1;
			switch (input1)
			{
				case 0:
					Console.WriteLine("위로 이동");
					break;
				case 1:
					Console.WriteLine("아래로 이동");
					break;
				case 2:
					Console.WriteLine("왼쪽로 이동");
					break;
				case 3:
					Console.WriteLine("오른쪽으로 이동");
					break;
			}

			// 오타나 관리에 취약한 방법
			string input2 = "위쪽";

			// -> 방향 자료형을 만들자!
			Direction dir = Direction.Up; // == Direction dir = 0;
										  // dir = Direction.Back; // 열거형에 정의되지 않았으므로 사용 불가

			switch (dir)
			{
				case Direction.Up:
					Console.WriteLine("위로 이동");
					break;
				case Direction.Down:
					Console.WriteLine("아래로 이동");
					break;
				case Direction.Left:
					Console.WriteLine("왼쪽으로 이동");
					break;
				case Direction.Right:
					Console.WriteLine("오른쪽으로 이동");
					break;
			}
		}

		enum Season
		{
			Spring,
			Summer,
			Autumm = 20,
			Winter
		}
		static void Main2(string[] args)
		{
			Season season1 = Season.Autumm;
			int value = (int)Season.Summer; // == int value = 1;

			Season season2 = (Season)1; // Season 형변환, season2에 Summer(1)가 저장된다.
			Console.WriteLine(season2);
			Season season3 = (Season)11; // season3에 그냥 11이 저장된다.
			Console.WriteLine(season3);
		}


		/* * * * * * *  
		 * 구조체 (Struct)
		 * 
         * 데이터와 관련 기능을 캡슐화할 수 있는 ^값^ 형식
         * 데이터를 저장하기 보관하기 위한 단위용도로 사용
		 * * * * * * */

		// <구조체 구성>
		// struct 구조체이름 { 구조체내용 }
		// 구조체 내용으로는 변수와 함수가 포함 가능

		struct MonsterStat
		{
			public int hp;
			public int mp;
			public int level;
			public float speed;
			public float range;
			public int exp;

		}

		// 구조체 사용 안했을 때...
		void Attack1(int hp, int mp, int level, float speed, float rangem, int exp)
		{

		}

		// 구조체 사용 했을 때
		void Attack2(MonsterStat stat)
		{

		}

		struct Vector3_1
		{
			public int x;
			public int y;
			public int z;

			public float Manatitude()
			{
				return (float)Math.Sqrt(x * x + y * y + z * z);
			}

		}

		static void Main3(string[] args)
		{
			// 구조체 사용 안했을 때..
			int monsterHP;
			int monsterMP;
			int monsterLevel;
			int monsterSpeed;
			int monsterRange;

			MonsterStat stat;
			stat.hp = 10;
			stat.mp = 5;
			stat.level = 1;
			stat.speed = 1.2f;
			stat.range = 3.5f;
			stat.exp = 10;

			Vector3 position;
			position.x = 5;
		}

		struct StudentInfo
		{
			public string name;
			public int math;
			public int english;
			public int science;

			public int GetSum()
			{
				return math + english + science;
			}

			public float GetAverage()
			{
				return (math + english + science) / 3.0f;
			}
		}
		static void Main4(string[] args)
		{
			StudentInfo kim;
			kim.name = "김땡땡";
			kim.math = 70;
			kim.english = 90;
			kim.science = 85;
			Console.WriteLine($"{kim.name}의 점수 총합은 {kim.GetSum()}입니다.");
		}



		// <구조체 초기화>
		// 반환형이 없는 구조체 이름의 함수를 초기화라 하며 구조체 변수들의 초기화를 진행하는 역할로 사용
		// 매개변수가 있는 초기화를 정의하여 구조체 변수의 값을 설정하기 위한 용도로 사용
		// 구조체의 초기화는 new 키워드를 통해서 사용

		struct Point
		{
			public int x;
			public int y;

			// 기본 초기화 : 굳이 안만들어도 기본 생성 되어있음
			public Point()
			{
				this.x = 0;
				this.y = 0;
			}

			// main에서 구조체 사용 선언하자마자 초기화 하고싶다면 반드시 만들어야하는 초기화 함수
			public Point(int x, int y)  // 구분 위해 언더바 추가, 아니면 this 사용
			{
				this.x = x; // this는 자기 자신 가리킴, 바로 위 public int x;
				this.y = y; // 초기화에서 모든 구조체 변수를 초기화하지 않으면 error 발생
			}
		}
		static void Main5(string[] args)
		{

			// 초기화를 안했을 때(초기화 함수 안만들었을 때)
			Point point1;
			point1.x = 1;
			Console.WriteLine($"{point1.x}");
			// Console.WriteLine($"{point1.y}"); // 오류

			Point point2 = new Point();
			Console.WriteLine($"{point2.x}, {point2.y}");

			Point point3 = new Point(2, 3);
			Console.WriteLine($"{point3.x}, {point3.y}");
		}

		struct PlayerStat
		{
			public int hp;
			public int mp;
			public float speed;
			public float range;

			public PlayerStat(Job job)
			{
				if (job == Job.Archor)
				{
					hp = 50;
					mp = 100;
					speed = 100;
					range = 200;
				}
			}
		}

		enum Job { Archor, Mage, Knight };

		static void Main6(string[] args)
		{
			// 초기화 안했을 때 하나하나 설정해주어야 한다!!!
			/*PlayerStat playerStat;
			
			Console.Write("직업을 선택하세요 : ");
			Job job = Job.Archor;

			if (job == Job.Archor)
			{
				playerStat.hp = 50;
				playerStat.mp = 200;
				playerStat.speed = 100;
				playerStat.range = 200;
			}*/

			Console.Write("직업을 선택하세요 : ");
			Job job = Job.Archor;

			PlayerStat playerState = new PlayerStat(Job.Archor);
		}



		// <구조체 복사>
		// 깊은 복수 : 구조체에 대입연산자(=)를 통해 구조체 내 모든 변수들의 값이 복사됨

		struct Vector3
		{
			public float x;
			public float y;
			public float z;

			public Vector3(float x, float y, float z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}
			public string ToString()
			{
				return $"({x},{y},{z})";
			}
		}
		static void Main(string[] args)
		{
			Vector3 source = new Vector3(1, 2, 3);

			Vector3 target = source;

			Console.WriteLine(source.ToString());
			Console.WriteLine(target.ToString());

			source.y = 10;

			Console.WriteLine(source.ToString());
			Console.WriteLine(target.ToString());
		}

		// <튜플> : 쓰지말고 구조체 쓰기!!!!! 나중으로 갈수록 관리가 어려워짐
	}
}