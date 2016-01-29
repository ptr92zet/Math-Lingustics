using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinAddTuringProgram
{
    public interface ITuringMachine
    {
        void MoveHeadLeft();
        void MoveHeadRight();

        string ReadTape();
        void WriteTape(string symbol);
    }
}
