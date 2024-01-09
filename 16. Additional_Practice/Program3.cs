using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Practice
{
	internal class Program3
	{
		public class Player
		{
			private int hp = 10;
			public int GetHp() // 읽기, 확인
			{
				return hp;
			}
			private void SetHp(int hp) // 수정
			{
				if (hp < 0 || hp > 99999)
					Console.WriteLine("의도하지 않은 사용방법");
				this.hp = hp;
			}
		}
		static void Main1(string[] args)
		{
			Player player = new Player();
			int playerhp = player.GetHp();
			Console.WriteLine(playerhp);
		}
	}
}
