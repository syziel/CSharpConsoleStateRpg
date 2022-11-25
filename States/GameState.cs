 using System.Collections;
 using CSharpConsoleStateRpg.GUI;
 using CSharpConsoleStateRpg.States;

 namespace CSharpConsoleStateRpg
{
	class GameState
		: State
	{
		ArrayList characterList;

		public GameState(Stack<State> States, ArrayList characterList)
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
			Gui.MenuTitle("Game State");
			Gui.MenuOption(1, "Character Creator");
			Gui.MenuOption(-1, "Exit");


			Gui.GetInput("Input");
			int input = Convert.ToInt32(Console.ReadLine());



			this.ProcessInput(input);




		}

	}
}


