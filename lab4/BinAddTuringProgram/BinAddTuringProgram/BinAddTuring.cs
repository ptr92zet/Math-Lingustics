using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinAddTuringProgram
{
    class BinAddTuring : ITuringMachine
    {
        private int tapeIndex;
        private int firstSymbolIndex;
        private string currentSymbol;
        private string initialTapeContent;

        private List<string> tape;
        private List<string>.Enumerator enumerator;
        private string blank;
        private string delimiter;

        public BinAddTuring(string blank, string delimiter)
        {
            this.blank = blank;
            this.delimiter = delimiter;
            this.tapeIndex = 0;
            this.firstSymbolIndex = 0;
            this.currentSymbol = null;
            //this.enumerator = tape.GetEnumerator();
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
            get
            {
                return this.initialTapeContent;
            }
            set
            {
                this.initialTapeContent = value;
            }
        }

        public int TapeIndex
        {
            get
            {
                return this.tapeIndex;
            }
            set
            {
                this.tapeIndex = value;
            }
        }
        public int FirstSymbolIndex
        {
            get
            {
                return this.firstSymbolIndex;
            }
            set
            {
                this.firstSymbolIndex = value;
            }
        }

        public void MoveHeadLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveHeadRight()
        {
            throw new NotImplementedException();
        }

        public string ReadTape()
        {
            currentSymbol = tape[tapeIndex];
            return currentSymbol;
        }

        public void WriteTape(string symbol)
        {
            tape[tapeIndex] = symbol;
        }
    }
}
