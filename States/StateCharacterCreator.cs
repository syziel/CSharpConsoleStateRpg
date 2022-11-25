using System.Collections;
using CSharpConsoleStateRpg.GameEntities;
using CSharpConsoleStateRpg.GUI;
using CSharpConsoleStateRpg.States;


namespace CSharpConsoleStateRpg
{
	class StateCharacterCreator
		: State
	{
		//Variables
		ArrayList characterList;

		//Private Functions

		private void CreateCharacter()
		{
			String name = "";
			Gui.GetInput("Name: ");
			name = Console.ReadLine();
			Gui.Announcement("Character created");

			this.characterList.Add(new Character(name));

		}

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
					break;
				case 1:
					this.CreateCharacter();
					break;
				default:
					break;
			}
		}

		public override void Update()
		{
			Gui.Title("Character Creator");
			Gui.MenuOption(0, "New Character");
			Gui.MenuOption(1, "edit Character");
			Gui.MenuOption(2, "Delete Character");
			Gui.MenuOption(-1, "Exit");


			Gui.GetInput("Input");
			int input = Convert.ToInt32(Console.ReadLine());

			this.ProcessInput ( input ) ;
		}
	}
}