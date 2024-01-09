namespace _14._Delegate_Practice2
{
	internal class Program
	{
		public class Player
		{
			public void Jump() { Console.WriteLine("플레이어가 점프~"); }
			public void Dash() { Console.WriteLine("플레이어가 대쉬~"); }
		}

		public class Button
		{
			public Action OnClick;
			public virtual void Click()
			{
				if (OnClick != null) { OnClick(); }
			}
		}
		static void Main(string[] args)
		{
			Player player = new Player();
			player.Jump();

			Button jumpButton = new Button();
			jumpButton.OnClick = player.Jump;

			jumpButton.Click();

			Button dashButton = new Button();
			dashButton.OnClick = player.Dash;

			dashButton.Click();
		}
	}
}