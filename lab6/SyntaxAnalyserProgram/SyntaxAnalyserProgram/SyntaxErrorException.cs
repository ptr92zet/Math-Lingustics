using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAnalyserProgram
{
    class SyntaxErrorException : Exception
    {
        public SyntaxErrorException()
        {
        }

        public SyntaxErrorException(string message) : base(message)
        {
        }

        public SyntaxErrorException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
