/* * * * * * *  
 * 주석(Comment)
 * 소스 코드에 영향 X, 소스 코드에 대한 설명.
 * * * * * * */

// <주석 종류>
//	//		: 한 줄 주석
//	/**/	: 범위 주석
//	///		: 문서 주석, 함수 또는 클래스 앞에서 /// 입력으로
//				자동완성 및 통합개발환경(IDE)에서 정보 표시 기능



/* * * * * * *   
 * Using 지시문
 * 
 * 소스코드의 상단부에 위치하며 네임스페이스를 선언함
 * 선언 이후 소스코드에서 네임스페이스 안의 기능을 사용
 * * * * * * */
using System;   // 네임스페이스 안의 기능을 아래 내용부터는 기본적으로 포함.
				// 이후 소스코드부터 System 네임스페이스 안의 기능을 사용


// using Network;

/* * * * * * *   
 * 네임스페이스(Namespace)
 * 
 * 동일한 이름의 구분을 위해 사용한 이름 공간.
 * 기능이나 구분이 비슷한 기능들을 하나의 이름 아래 묶는 기능
 * 수많은 클래스 사용에 혼란이 적도록 용도/분야 별로 정리
 * ex) namespace UnityEditor{}, namespace UnityEngine{}
 * * * * * * */
namespace _00._Programming  // 네임스페이스 안의 기능을 Programming 이름 아래 묶음
{
	/* * * * * * *   
	* 클래스(Class)
	* 
	* C#은 클래스가 기본 단위.
	* C# 프로그램을 구성하는 기본 단위
	* 데이터와 기능으로 구성
	* * * * * * */
	class Program
	{
		/* * * * * * *   
		* Main 함수
		* 
		* 프로그램의 처음 시작 지점이 되는 함수
		* C# 프로그램은 반드시 하나의 Main 함수를 포함해야 함
		* * * * * * */

		/// <summary>
		/// 여기에 설명을 쓰면 문서처럼 쓸 수 있음
		/// 클래스 앞, 메인 앞에서도 ///로 자동 완성 문서 주석
		/// </summary>
		/// <param name="args"></param> // 여기에는 매개변수 작성
		static void Main(string[] args)
		{
			//System.Console.WriteLine("Hello, World!");
			//Client.Console x;
			//Network.Console y;
			// Client와 Console이 겹치므로 이 경우에는 Network 적어주어야 함.
			//Delay z;

			Console.WriteLine("로그인");
			Console.WriteLine("캐릭터 선택");
			Console.WriteLine("마을 진입");
			Console.WriteLine("아이템 구매");
			Console.WriteLine("던전 진입");
			Console.WriteLine("슬라임 사냥");
			Console.WriteLine("접속 종료");


			// <표준 입출력>
			// 콘솔 : 표준 입출력하는 것.
			//		컴퓨터와 사용자가 텍스트 형태로 소통하기 위한 수단
			// Console.WriteLine	: 콘솔에 출력하고 줄 바꿈
			// Console.Write		: 콘솔에 출력하고 줄 바꾸지 않음
			// Console.ReadLine		: 콘솔을 통해 한 줄 입력받음(엔터 누르기 전까지 대기)
			// Console.ReadKey		: 콘솔을 통해 키 입력받음(한 번 누르면 바로 넘어감)

			Console.WriteLine("\n한 줄 출력");
			Console.Write("캐릭터 이름은 : ");
			Console.ReadLine();
			Console.WriteLine("입력이 완료되었습니다!\n");

			Console.WriteLine("<게임 타이틀>\n\n");
			Console.Write("메뉴 선택 : ");
			Console.ReadLine();

			Console.Write("\n콘솔을 통해 키 입력 : ");
			Console.ReadKey();
			Console.WriteLine("입력이 완료되었습니다!\n");


			// -------------------------------------------

			Console.WriteLine("");
			Console.Write("");

			Console.Write("캐릭터의 이름을 입력하세요.");
			// Console.ReadLine();
			string name = Console.ReadLine();
			Console.WriteLine("이름 " + name + " 입니다.");

			Console.Write("키를 입력하세요.");
			Console.ReadKey();

		}
	}
}