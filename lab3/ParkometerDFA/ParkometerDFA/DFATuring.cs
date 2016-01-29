using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFATuring
{
    public class DFATuring : BinAddTuringProgram.ITuringMachine
    {
        private int headPosition;
        private int maxTapeLength;

        private string currentCoin;
        private string initialTapeContent;

        private State currentState;
           
        private List<string> tape;
        

        public DFATuring(int maxLength)
        {
            this.Reset();
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

        public string CurrentCoin
        {
            get
            {
                return this.currentCoin;
            }
            private set
            {
                this.currentCoin = value;
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

        public string Tape
        {
            get
            {
                string[] tapeSymbols;
                StringBuilder builder = new StringBuilder();
                tapeSymbols = this.tape.ToArray();
                foreach (string symbol in tapeSymbols)
                {
                    builder.Append(symbol);
                }
                return builder.ToString();
            }
        }

        public bool IsTapeInitialized { get; set; }

        public void TakeStep()
        {
            if (tape != null)
            {
                this.currentCoin = ReadTape();
                if (currentCoin != "")
                {
                    switch (CurrentState)
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
                        case State.Q7F:
                            moveFromQ7F();
                            break;
                        case State.Q8:
                            moveFromQ8();
                            break;
                        case State.Q9:
                            moveFromQ9();
                            break;
                        case State.Q10:
                            moveFromQ10();
                            break;
                        case State.Q11:
                            moveFromQ11();
                            break;
                    }
                }
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
            if (tape.Count != 0)
            {
                currentCoin = tape[HeadPosition];
            }
            else
            {
                currentCoin = "";
            }
            return currentCoin;
        }

        public void WriteTape(string symbol)
        {
            tape[HeadPosition] = symbol;
        }

        public void Reset()
        {
            this.headPosition = 0;
            this.currentCoin = "";
            this.currentState = State.Q0;
            this.IsTapeInitialized = false;
        }

        public void AddToTape(string coin)
        {
            tape.Add(coin);
        }

        public void InitializeTape(List<string> initList)
        {
            this.tape = new List<string>(maxTapeLength);
            foreach (string symbol in initList)
            {
                this.tape.Add(symbol);
            }
            IsTapeInitialized = true;
        }

        private void moveFromQ0()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q1;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q3;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q5;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ1()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q2;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q3;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q6;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ2()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q3;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q4;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q7F;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ3()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q4;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q5;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q8;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ4()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q5;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q6;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q9;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ5()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q6;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q7F;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q10;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ6()
        {
            switch (this.CurrentCoin)
            {
                case "1":
                    CurrentState = State.Q7F;
                    WriteTape("1");
                    MoveHeadRight();
                    break;
                case "2":
                    CurrentState = State.Q8;
                    WriteTape("2");
                    MoveHeadRight();
                    break;
                case "5":
                    CurrentState = State.Q11;
                    WriteTape("5");
                    MoveHeadRight();
                    break;
            }
        }
        private void moveFromQ7F()
        {
            CurrentState = State.Q7F;
            Console.Write("FINAL STATE REACHED!");
        }
        private void moveFromQ8()
        {
            CurrentState = State.Q7F;
            WriteTape("1");
            CurrentCoin = ReadTape();
            MoveHeadRight();
        }
        private void moveFromQ9()
        {
            CurrentState = State.Q7F;
            WriteTape("2");
            CurrentCoin = ReadTape();
            MoveHeadRight();
        }
        private void moveFromQ10()
        {
            CurrentState = State.Q10;
            WriteTape("2");
            CurrentCoin = ReadTape();
            MoveHeadRight();
            CurrentState = State.Q7F;
            WriteTape("1");
            CurrentCoin = ReadTape();
            MoveHeadRight();
        }
        private void moveFromQ11()
        {
            CurrentState = State.Q11;
            WriteTape("2");
            CurrentCoin = ReadTape();
            MoveHeadRight();
            CurrentState = State.Q7F;
            WriteTape("2");
            CurrentCoin = ReadTape();
            MoveHeadRight();
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
        Q7F,
        Q8,
        Q9,
        Q10,
        Q11
    }
}
