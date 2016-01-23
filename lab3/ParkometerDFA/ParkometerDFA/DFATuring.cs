using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFATuring
{
    public class DFATuring
    {
        private State currentState;
        private int currentCoin;
        private int currentTapeIndex;
        private List<State> stateList = new List<State>();
        private List<int> tape = new List<int>();
        private List<int> unnecessaryCoins = new List<int>();
        int rest = 0;
        private bool reachedEndOfTape;

        public DFATuring()
        {
            this.Reset();
        }

        public State CurrentState
        {
            get
            {
                return currentState;
            }
        }

        public int CurrentTapeIndex
        {
            get
            {
                return currentTapeIndex;
            }
        }

        public int[] GetTapeElements()
        {
            return tape.ToArray();
        }

        public void AddToTape(int coin)
        {
            tape.Add(coin);
        }

        private void SetCurrentState(State newState)
        {
            this.currentState = newState;
            stateList.Add(this.currentState);
        }

        private void ApplyWord1()
        {
            switch (this.CurrentState)
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
                    SetCurrentState(State.Full);
                    unnecessaryCoins.Add(1);
                    rest += 1;
                    break;
            }
        }
        private void ApplyWord2()
        {
            switch (this.CurrentState)
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
                    SetCurrentState(State.Full);
                    rest += 1;
                    break;
                case State.Full:
                    SetCurrentState(State.Full);
                    unnecessaryCoins.Add(2);
                    rest += 2;
                    break;
            }
        }
        private void ApplyWord5()
        {
            switch (this.CurrentState)
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
                    SetCurrentState(State.Full);
                    rest += 1;
                    break;
                case State.PLN4:
                    SetCurrentState(State.Full);
                    rest += 2;
                    break;
                case State.PLN5:
                    SetCurrentState(State.Full);
                    rest += 3;
                    break;
                case State.PLN6:
                    SetCurrentState(State.Full);
                    rest += 4;
                    break;
                case State.Full:
                    SetCurrentState(State.Full);
                    unnecessaryCoins.Add(5);
                    rest += 5;
                    break;
            }
        }

        public bool MoveToNextState()
        {
            if (tape != null && currentTapeIndex < tape.Count)
            {
                currentCoin = tape[currentTapeIndex];
                switch (currentCoin)
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
                currentTapeIndex++;
                if (currentTapeIndex == tape.Count)
                {
                    reachedEndOfTape = true;
                }
            }

            return reachedEndOfTape;
            
        }

        public string RetrieveAllTransitions()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(retrieveStateTransitions());
            builder.Append(retrieveUnnecessaryCoins());
            builder.Append(retrieveRest());
            builder.Append(retrieveReturnedCoins());
            return builder.ToString();
        }

        public void Reset()
        {
            this.stateList.Clear();
            this.tape.Clear();
            this.unnecessaryCoins.Clear();
            this.currentState = State.Empty;
            this.rest = 0;
            this.currentCoin = 0;
            this.currentTapeIndex = 0;
            this.reachedEndOfTape = false;
            this.stateList.Add(this.currentState);
        }

        private string retrieveStateTransitions()
        {
            StringBuilder builder = new StringBuilder("States: ");
            foreach (State state in stateList)
            {
                builder.Append(state.ToString()).Append(", ");
            }
            builder.Append("\n");
            return builder.ToString();
        }

        private string retrieveUnnecessaryCoins()
        {
            StringBuilder builder = new StringBuilder("Unnecessary coins: ");
            foreach (int coin in unnecessaryCoins)
            {
                builder.Append(coin.ToString()).Append(", ");
            }
            builder.Append("\n");
            return builder.ToString();
        }

        private string retrieveRest()
        {
            return "Rest: " + rest.ToString() + "\n";
        }

        private string retrieveReturnedCoins()
        {
            StringBuilder builder = new StringBuilder("Returned coins: ");

            int dividedByFive = this.rest / 5;
            Console.WriteLine("dividedByFive " + dividedByFive.ToString());
            for (int i = 0; i < dividedByFive; i++)
            {
                builder.Append("5, ");
            }

            int restFromDivisionByFive = this.rest - (dividedByFive * 5);
            Console.WriteLine("restFromDivisionByFive " + restFromDivisionByFive.ToString());
            if (restFromDivisionByFive > 1)
            {
                int dividedByTwo = restFromDivisionByFive / 2;
                Console.WriteLine("dividedByTwo " + dividedByTwo.ToString());
                for (int i = 0; i < dividedByTwo; i++)
                {
                    builder.Append("2, ");
                }
                int restFromDivisionByTwo = dividedByTwo % 2;
                Console.WriteLine("restFromDivisionByTwo " + restFromDivisionByTwo.ToString());
                if (restFromDivisionByTwo == 1)
                {
                    builder.Append("1, ");
                }
            }
            else
            {
                builder.Append("1, ");
            }
            builder.Append("\n");

            Console.WriteLine("builder " + builder.ToString());
            return builder.ToString();
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
