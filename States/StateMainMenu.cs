using System.Collections;

using CSharpConsoleStateRpg.GUI;
using CSharpConsoleStateRpg.States;

namespace CSharpConsoleStateRpg
{
	class StateMainMenu
		: State
	{
		protected ArrayList characterList;

		public StateMainMenu(Stack<State> states, ArrayList characterList)
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

					break;

				case 2:
					this.states.Push(new StateCharacterCreator(this.states, this.characterList));
					break;
				case 3:
					Console.Write(this.characterList.Count);
					break;
				default:

					break;
			}
		}


		public override void Update()
		{

			Gui.MenuTitle("Main Menu");

			Gui.MenuOption(1, "New Game");
			Gui.MenuOption(2, "Character Creator");
			Gui.MenuOption(2, "List Characters");
			Gui.MenuOption(-1, "Exit");

			Gui.GetInput("Input");
			int input = Convert.ToInt32(Console.ReadLine());


			this.ProcessInput(input);

		}

	}
}
