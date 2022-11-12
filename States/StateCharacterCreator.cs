using CSharpConsoleStateRpg.GUI;

namespace CSharpConsoleStateRpg.States
{
	class StateCharacterCreator
		: State
	{
		public StateCharacterCreator(Stack<State> states)
			: base(states)
		{

		}

		public void ProcessInput(int input)
		{
			switch (input)
			{
				case -1:

					this.end = true;

					break ;
			}
		}

		public override void Update()
		{
			Console.WriteLine(Gui.Title("Character Creator"));
			Console.WriteLine(Gui.MenuOption(0, "New Character"));
			Console.WriteLine(Gui.MenuOption(1, "edit Character"));
			Console.WriteLine(Gui.MenuOption(2, "Delete Character"));
			Console.WriteLine(Gui.MenuOption(-1, "Exit"));


			Gui.GetInput("Input");
			int input = Convert.ToInt32(Console.ReadLine());

			this.ProcessInput ( input ) ;
		}
	}
}