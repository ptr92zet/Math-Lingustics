using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFA
{
    public class DFA
    {
        private State currentState;
        private int[] alphabet = new int[3] { 1, 2, 5 };
        private List<State> stateList = new List<State>();

        public DFA(State initialState)
        {
            this.currentState = initialState;
            stateList.Add(this.currentState);
        }

        public State GetCurrentState()
        {
            return currentState;
        }

        private void SetCurrentState(State newState)
        {
            this.currentState = newState;
            stateList.Add(this.currentState);
        }

        private void ApplyWord1()
        {
            switch (GetCurrentState())
            {
                case State.Empty:
                    SetCurrentState(State.PLN1);
                    break;
                case State.PLN1:
                    SetCurrentState(State.PLN2);
                    break;
                case State.PLN2:
                    SetCurrentState(State.PLN3);
                    break;
                case State.PLN3:
                    SetCurrentState(State.PLN4);
                    break;
                case State.PLN4:
                    SetCurrentState(State.PLN5);
                    break;
                case State.PLN5:
                    SetCurrentState(State.PLN6);
                    break;
                case State.PLN6:
                    SetCurrentState(State.Full);
                    break;
                case State.Full:
                    SetCurrentState(State.Empty);
                    break;
            }
        }
        private void ApplyWord2()
        {
            switch (GetCurrentState())
            {
                case State.Empty:
                    SetCurrentState(State.PLN2);
                    break;
                case State.PLN1:
                    SetCurrentState(State.PLN3);
                    break;
                case State.PLN2:
                    SetCurrentState(State.PLN4);
                    break;
                case State.PLN3:
                    SetCurrentState(State.PLN5);
                    break;
                case State.PLN4:
                    SetCurrentState(State.PLN6);
                    break;
                case State.PLN5:
                    SetCurrentState(State.Full);
                    break;
                case State.PLN6:
                    SetCurrentState(State.Empty);
                    break;
                case State.Full:
                    SetCurrentState(State.Empty);
                    break;
            }
        }
        private void ApplyWord5()
        {
            switch (GetCurrentState())
            {
                case State.Empty:
                    SetCurrentState(State.PLN5);
                    break;
                case State.PLN1:
                    SetCurrentState(State.PLN6);
                    break;
                case State.PLN2:
                    SetCurrentState(State.Full);
                    break;
                case State.PLN3:
                    SetCurrentState(State.Empty);
                    break;
                case State.PLN4:
                    SetCurrentState(State.Empty);
                    break;
                case State.PLN5:
                    SetCurrentState(State.Empty);
                    break;
                case State.PLN6:
                    SetCurrentState(State.Empty);
                    break;
                case State.Full:
                    SetCurrentState(State.Empty);
                    break;
            }
        }

        public State MoveToNextState(int word)
        {
            switch(word)
            {
                case 1:
                    ApplyWord1();
                    break;
                case 2:
                    ApplyWord2();
                    break;
                case 5:
                    ApplyWord5();
                    break;
            }
            return GetCurrentState();
        }
        
        public string ListAllTransitions()
        {
            string transitionsList = "";
            foreach (State state in stateList)
            {
                transitionsList += state.ToString() + '\n';
            }
            stateList.Clear();
            return transitionsList;
        }

    }

    public enum State
    {
        Empty = 0,
        PLN1,
        PLN2,
        PLN3,
        PLN4,
        PLN5,
        PLN6,
        Full
    }
}
