namespace _15._Event_Practice
{
	internal class Program
	{
		public class Player
		{
			public event Action OnGetCoin;

			public void GetCoin()
			{
				Console.WriteLine("플레이어가 코인을 획득함.");
				if (OnGetCoin != null)
				{
					OnGetCoin();
				}
			}
		}

		public class UI { public void CoinUI() { Console.WriteLine("UI에 코인을 갱신"); } }

		public class SFX { public void CoinSound() { Console.WriteLine("코인 먹는 사운드 출력"); } }

		public class VFX { public void CoinEffect() { Console.WriteLine("코인 먹는 이펙트 보여주기"); } }

		static void Main(string[] args)
		{
			Player player = new Player();
			UI ui = new UI();
			SFX sfx = new SFX();
			VFX vfx = new VFX();

			player.OnGetCoin += ui.CoinUI;
			player.OnGetCoin += sfx.CoinSound;
			player.OnGetCoin += vfx.CoinEffect;

			player.GetCoin();
		}
	}
}
