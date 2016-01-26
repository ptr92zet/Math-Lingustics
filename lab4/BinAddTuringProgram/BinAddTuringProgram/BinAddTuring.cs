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

        public BinAddTuring(string blank, string content)
        {
            this.headPosition = 0;
            this.currentSymbol = "";
            this.currentState = State.Q0;
            this.blank = blank;
            this.initialTapeContent = content;
            this.maxTapeLength = content.Length;
            this.tape = new List<string>(maxTapeLength);
            foreach(char symbol in initialTapeContent)
            {
                tape.Add(symbol.ToString());
            }
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
            private set
            {
                this.currentSymbol = value;
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

        public int MaxTapeLength
        {
            get
            {
                return this.maxTapeLength;
            }
        }

        public string Tape
        {
            get
            {
                string[] tapeSymbols;
                StringBuilder builder = new StringBuilder();
                tapeSymbols = tape.ToArray();
                foreach (string symbol in tapeSymbols)
                {
                    builder.Append(symbol);
                }
                return builder.ToString();
            }
        }
        public void TakeStep()
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

        private void moveFromQ0()
        {
            switch(this.CurrentSymbol)
            {
                case "#":
                    CurrentState = State.Q0;
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q1;
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q1;
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
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q1;
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q1;
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
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q3;
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
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q3;
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q3;
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
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q4;
                    WriteTape("0");
                    MoveHeadRight();
                    break;
                case "1":
                    CurrentState = State.Q4;
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
                    WriteTape("#");
                    //MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q5;
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q6;
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
                    WriteTape("#");
                    MoveHeadRight();
                    break;
                case "0":
                    CurrentState = State.Q6;
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
                    WriteTape("1");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q9;
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
                    WriteTape("#");
                    MoveHeadLeft();
                    break;
                case "0":
                    CurrentState = State.Q8;
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q8;
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
                    WriteTape("1");
                    MoveHeadLeft();
                    break;
                case "1":
                    CurrentState = State.Q9;
                    WriteTape("0");
                    MoveHeadLeft();
                    break;
            }
        }
    }

    public enum State
    {
        Q0 = 0,
        Q1,
        Q2,
        Q3,
        Q4,
        Q5,
        Q6,
        Q7,
        Q8,
        Q9,
        QF
    }
}
