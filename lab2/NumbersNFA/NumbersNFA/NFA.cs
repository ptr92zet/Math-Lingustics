using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNFA
{
    enum State
    {
        Initial,
        Q0,
        Q1,
        Q2,
        Q3,
        Q4,
        Q5,
        Q6,
        Q7,
        Q8,
        Q9,
        Final
    };

    class NFA
    {
        private string fileText;
        private string[] tokens;
        private string currentToken;
        private State currentState;
        private State previousState;
        private List<State> states;
        private int counter;

        public NFA()
        {
            this.currentState = State.Initial;
            this.previousState = State.Initial;
            states = new List<State>();
            states.Add(this.currentState);
            this.counter = 0;
        }

        public string GetFileText()
        {
            return this.fileText;
        }
        public void SetFileText(string text)
        {
            this.fileText = text;
        }
        public string[] GetTokensArray()
        {
            return this.tokens;
        }
        public void SetTokensArray(string[] tokens)
        {
            this.tokens = tokens;
        }
        public string GetCurrentToken()
        {
            return this.currentToken;
        }
        public void SetCurrentToken(string token)
        {
            this.currentToken = token;
        }
        public int GetCurrentTokenCounter()
        {
            return this.counter;
        }
        public void SetCurrentTokenCounter(int counter)
        {
            this.counter = counter;
        }
        public void Reset()
        {
            this.counter = 0;
            this.previousState = State.Initial;
            this.currentState = State.Initial;
            this.currentToken = "";
            this.tokens = null;
            this.states.Clear();
        }

        //ApplyWord

        private void ApplyWord0()
        {
            if (states.Contains(State.Q0))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q0;
                states.Add(State.Q0);
            }
        }
        private void ApplyWord1()
        {
            if (states.Contains(State.Q1))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q1;
                states.Add(State.Q1);
            }
        }
        private void ApplyWord2()
        {
            if (states.Contains(State.Q2))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q2;
                states.Add(State.Q2);
            }
        }
        private void ApplyWord3()
        {
            if (states.Contains(State.Q3))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q3;
                states.Add(State.Q3);
            }
        }
        private void ApplyWord4()
        {
            if (states.Contains(State.Q4))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q4;
                states.Add(State.Q4);
            }
        }
        private void ApplyWord5()
        {
            if (states.Contains(State.Q5))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q5;
                states.Add(State.Q5);
            }
        }
        private void ApplyWord6()
        {
            if (states.Contains(State.Q6))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q6;
                states.Add(State.Q6);
            }
        }
        private void ApplyWord7()
        {
            if (states.Contains(State.Q7))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q7;
                states.Add(State.Q7);
            }
        }
        private void ApplyWord8()
        {
            if (states.Contains(State.Q8))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q8;
                states.Add(State.Q8);
            }
        }
        private void ApplyWord9()
        {
            if (states.Contains(State.Q9))
            {
                this.previousState = this.currentState;
                this.currentState = State.Final;
                states.Add(State.Final);
            }
            else
            {
                this.previousState = this.currentState;
                this.currentState = State.Q9;
                states.Add(State.Q9);
            }
        }


        public string PrintAllStates()
        {
            string st = "";
            foreach (State state in this.states)
            {
                st += state.ToString() + " ";
            }
            return st;
        }

        
        public string TakeStep(int charCounter)
        {
            Console.WriteLine("Before switch!");
            switch (this.GetCurrentToken().ToCharArray()[charCounter])
            {
                case '0':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord0();
                    break;
                case '1':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord1();
                    break;
                case '2':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord2();
                    break;
                case '3':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord3();
                    break;
                case '4':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord4();
                    break;
                case '5':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord5();
                    break;
                case '6':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord6();
                    break;
                case '7':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord7();
                    break;
                case '8':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord8();
                    break;
                case '9':
                    Console.WriteLine("Current char: " + this.GetCurrentToken().ToCharArray()[charCounter].ToString() + ", current state: " + this.currentState.ToString() + ", previous state: " + this.previousState.ToString());
                    ApplyWord9();
                    break;
            }
            return this.currentState.ToString();

        }
    }
}
