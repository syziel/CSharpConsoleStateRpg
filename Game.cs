using CSharpConsoleStateRpg.GUI;
using CSharpConsoleStateRpg.States;

namespace CSharpConsoleStateRpg
{
    class Game
    {
        //Variable
        private bool end;

        private Gui gui;

        public Stack<States.State> states;

        //Constructors and Destructor
        public Game()
        {
            this.InitVariables();
            this.InitStates();
            this.InitGui();
        }

        private void InitGui()
        { this.gui = new Gui(); }

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

        public bool End

        {
            get { return this.End; }
            set { this.End = value; }
        }
    }
}