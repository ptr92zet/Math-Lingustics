using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexpTesterProgram
{
    public interface IRegexpTester
    {
        bool Test(string stringToTest);
    }
}
