using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Practice
{
	internal class Program4
	{

		public class Player
		{
			public event Action<int> OnSetHP;

			private int hp = 10;
			public int Hp
			{
				get { return hp; }
				set { hp = value; OnSetHP(hp); }
			}
		}

		public class UI
		{
			public void HpAlram(int hp)
			{
				Console.WriteLine($"플레이어 체력이 {hp} 이/가 됩니다. UI 체력바가 {hp}가 됩니다.");
			}
		}


		static void Main1(string[] args)
		{
			Player player = new Player();
			UI ui = new UI();

			player.OnSetHP += ui.HpAlram;

			player.Hp = 20;
			player.Hp = 30;
			player.Hp = 40;

		}
	}
}
