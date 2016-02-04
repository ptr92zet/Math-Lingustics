using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAnalyserProgram
{
    class ReachedEndOfStringException : Exception
    {
        public ReachedEndOfStringException()
        {
        }

        public ReachedEndOfStringException(string message) : base(message)
        {
        }

        public ReachedEndOfStringException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
