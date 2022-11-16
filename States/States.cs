
namespace CSharpConsoleStateRpg.States
{
    class State
    {
        protected Stack<State> states;


        protected bool end = false;


        public State(Stack<State> States)
        {
            this.states = States;
        }

        public bool QuitEnd()
        {
            return this.end;
        }

        public virtual void Update()
        {

        }

    }
}
