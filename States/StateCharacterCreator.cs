using System.Collections;

using CSharpConsoleStateRpg.GUI;
using CSharpConsoleStateRpg.States;


namespace CSharpConsoleStateRpg
{
	class StateCharacterCreator
		: State
	{
		ArrayList characterList;

		public StateCharacterCreator(Stack<State> states, ArrayList characterList)
			: base(states)
		{
			this.characterList = characterList;

		}

		public void ProcessInput(int input)
		{
			switch (input)
			{
				case -1:

					this.end = true;

		 			break ;

				case 2:
					this.states.Push(new StateCharacterCreator(this.states, this.characterList));
					break;
				default:
					break;
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