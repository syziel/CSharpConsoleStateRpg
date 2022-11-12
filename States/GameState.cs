using CSharpConsoleStateRpg.GUI;


namespace CSharpConsoleStateRpg.States
{
	class GameState
		: State
	{

		public GameState(Stack<State> States)
			: base(States)
		{

		}

		public void ProcessInput(int input)
		{
			switch (input)
			{
				case -1:

					this.end = true;

					break;
			}
		}
		public override void Update()
		{
			Console.WriteLine(Gui.MenuTitle("Game State"));
			Console.WriteLine(Gui.MenuOption(1, "Character Creator"));
			Console.WriteLine(Gui.MenuOption(-1, "Exit"));


			Gui.GetInput("Input");
			int input = Convert.ToInt32(Console.ReadLine());



			this.ProcessInput ( input ) ;




		}

	}
}


