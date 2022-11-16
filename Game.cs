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


		//Constructors and Destructors

		//Constructors and Destructor

		public Game()
		{
			this.InitVariables();
			this.InitStates();

		}

		private void InitStates()
		{
			this.states = new Stack<States.State>();

			//Push first state
			this.states.Push(new StateMainMenu(this.states));
		}

		//private functions
		private void InitVariables()
		{ this.end = false; }

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