using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntaxAnalyserProgram
{
    class SyntaxAnalyser
    {
        private LinkedList<string> input;
        private LinkedList<string>.Enumerator enumerator;
        private string currentTerminal;
        private bool isCorrect;


        public SyntaxAnalyser(string inputText)
        {
            input = new LinkedList<string>();
            foreach (char s in inputText)
            {
                input.AddLast(s.ToString());
            }
            isCorrect = true;
            enumerator = input.GetEnumerator();
            enumerator.Dispose();

        }

        public bool IsCorrect
        {
            get
            {
                return this.isCorrect;
            }
        }

        private void readTerminal()
        {
            if (enumerator.MoveNext())
            {
                this.currentTerminal = enumerator.Current;
                Console.WriteLine("Current symbol: " + currentTerminal);
                return;
            }
            else
            {
                throw new ReachedEndOfStringException("Reached end of input string!");
            }
        }

        private void parseTerminal(string parsedTerminal)
        {
            if (this.currentTerminal.Equals(parsedTerminal))
            {
                Console.WriteLine("Parsing terminal: " + parsedTerminal + ", current terminal: " + currentTerminal);
                return;
            }
            else
            {
                this.isCorrect = false;
                throw new SyntaxErrorException("Expected: " + parsedTerminal + ", read: " + this.currentTerminal);
            }
        }

        public void Parse()
        {
            try
            {
                Console.WriteLine("Starting Parse() method, reading terminal");
                readTerminal();
                //if (this.currentTerminal.Equals("("))
                //{
                //    Console.WriteLine("Current terminal equals (");
                //    Parse();
                //    readTerminal();
                //    parseTerminal(")");
                //}
                //else
                //{
                //Console.WriteLine("Current terminal is not a (");
                parseDigit(this.currentTerminal);
                readTerminal();
                while (!isOperator(this.currentTerminal))
                {
                    parseDigit(this.currentTerminal);
                    readTerminal();
                }
                //}
                parseOperator(this.currentTerminal);
                Parse();
                Console.WriteLine("End of try-catch block");

            }
            catch (ReachedEndOfStringException e)
            {
                Console.WriteLine("ReachedEndOfString: " + e.Message + ", IS PARSED: " + this.isCorrect.ToString());
            }
            catch (SyntaxErrorException e)
            {
                Console.WriteLine("SYNTAX ERROR: " + e.Message);
            }

        }

        private void parseDigit(string symbol)
        {
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (digits.Contains<string>(symbol))
            {
                Console.WriteLine("In parseDigit function. Parsing digit: " + symbol);
                return;
            }
            else
            {
                this.isCorrect = false;
                throw new SyntaxErrorException("The symbol: " + symbol + " is not a digit!");
            }
        }

        private bool isDigit(string symbol)
        {
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (digits.Contains<string>(symbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void parseOperator(string symbol)
        {
            string[] operators = { "*", "/", "+", "-", "^" };
            if (operators.Contains<string>(symbol))
            {
                Console.WriteLine("In parseOperator function. Parsing operator: " + symbol);
                return;
            }
            else
            {
                this.isCorrect = false;
                throw new SyntaxErrorException("The symbol: " + symbol + " is not an operator!");
            }
        }

        private bool isOperator(string symbol)
        {
            string[] operators = { "*", "/", "+", "-", "^" };
            if (operators.Contains<string>(symbol))
            {
                Console.WriteLine("In isOperator function. Found an operator: " + symbol);
                return true;
            }
            else
            {
                Console.WriteLine("In isOperator function. It is not operator: " + symbol);
                return false;
            }
        }
    }
}
