using System.Collections;
using CSharpConsoleStateRpg.States;

namespace CSharpConsoleStateRpg
{
	class Game
	{
		//Variable
		private bool end;

		public bool End

		{
			get { return this.end; }
			set { this.end = value; }
		}

		private Stack<States.State> states;
		private ArrayList characterList;


		//Constructors and Destructor

		public Game()
		{
			this.InitVariables();
			this.InitCharacterList();
			this.InitStates();

		}

		private void InitVariables()

		{ this.end = false; }

		private void InitCharacterList()
		{
			this.characterList = new ArrayList();
		}

		private void InitStates()
		{

			//Push first state
			this.states.Push(new StateMainMenu(this.states, this.characterList));
		}

		//private functions


		public void Run()
		{
			while (this.states.Count > 0)
			{
				this.states.Peek().Update();

				if (this.states.Peek().QuitEnd())
					this.states.Pop();
			}

			Console.WriteLine("Ending Game...");
		}
	}
}