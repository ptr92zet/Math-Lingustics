using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinAddTuringProgram
{
    class BinAddTuring : ITuringMachine
    {
        private int headPosition;
        private int maxTapeLength;

        private string currentSymbol;
        private string blank;
        private string initialTapeContent;

        private List<string> tape;

        private State currentState;
        private List<State> states;

        public BinAddTuring(string blank, int maxLength)
        {
            this.headPosition = 0;
            this.currentSymbol = "";
            this.currentState = State.Q0;
            this.states.Add(this.currentState);

            this.blank = blank;
            this.maxTapeLength = maxLength;
            this.tape = new List<string>(maxTapeLength);
        }

        public State CurrentState
        {
            get
            {
                return this.currentState;
            }
            private set
            {
                this.currentState = value;
            }
        }

        public string CurrentSymbol
        {
            get
            {
                return this.currentSymbol;
            }
            set
            {
                this.currentSymbol = value;
            }
        }

        public string InitialTapeContent
        {
            set
            {
                this.initialTapeContent = value;
            }
        }

        public int HeadPosition
        {
            get
            {
                return this.headPosition;
            }
            private set
            {
                this.headPosition = value;
            }
        }

        public State TakeStep()
        {
            this.CurrentSymbol = ReadTape();
            switch(CurrentState)
            {
                case State.Q0:
                    moveFromQ0();
                    break;
                case State.Q1:
                    moveFromQ1();
                    break;
                case State.Q2:
                    moveFromQ2();
                    break;
                case State.Q3:
                    moveFromQ3();
                    break;
                case State.Q4:
                    moveFromQ4();
                    break;
                case State.Q5:
                    moveFromQ5();
                    break;
                case State.Q6:
                    moveFromQ6();
                    break;
                case State.Q7:
                    moveFromQ7();
                    break;
                case State.Q8:
                    moveFromQ8();
                    break;
                case State.Q9:
                    moveFromQ9();
                    break;
                case State.QF:
                    break;
            }
            return CurrentState;
        }

        private void moveFromQ0()
        {
            switch(this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q0;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q1;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q1;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ1()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q2;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q1;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q1;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ2()
        {
            switch (this.CurrentSymbol)
            {
                case "0":
                    CurrentState = State.Q5;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q3;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ3()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q4;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q3;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q3;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ4()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q7;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q4;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q4;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ5()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.QF;
                    states.Add(CurrentState);
                    WriteTape("#");
                    //MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q5;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q6;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ6()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q4;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q6;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ7()
        {
            switch (this.CurrentSymbol)
            {
                case "0":
                    CurrentState = State.Q8;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q9;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
            }
        }
        private void moveFromQ8()
        {
            switch (this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q2;
                    states.Add(CurrentState);
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q8;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q8;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadLeft();
                    break;
            }
        }
        private void moveFromQ9()
        {
            switch (this.CurrentSymbol)
            {
                case "0":
                    CurrentState = State.Q8;
                    states.Add(CurrentState);
                    WriteTape("1");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q9;
                    states.Add(CurrentState);
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
            }
        }

        public void MoveHeadLeft()
        {
            if (HeadPosition > 0)
            {
                HeadPosition--;
            }
            else
            {
                throw new Exception("Stepped out out the tape!");
            }
        }

        public void MoveHeadRight()
        {
            if (HeadPosition < tape.Count)
            {
                HeadPosition++;
            }
        }

        public string ReadTape()
        {
            currentSymbol = tape[HeadPosition];
            return currentSymbol;
        }

        public void WriteTape(string symbol)
        {
            tape[HeadPosition] = symbol;
        }
    }

    //public enum State
    //{
    //    Q0 = 0,
    //    Q1,
    //    Q2,
    //    Q3,
    //    Q4,
    //    Q5,
    //    Q6,
    //    Q7,
    //    Q8,
    //    Q9,
    //    QF
    //}
}
