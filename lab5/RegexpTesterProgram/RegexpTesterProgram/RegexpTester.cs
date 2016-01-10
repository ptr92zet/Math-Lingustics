using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexpTesterProgram
{
    public class RegexpTester : IRegexpTester
    {
        public string CurrentRegexp { get; set; }

        public bool Test(string stringToTest)
        {
            Regex r = new Regex(CurrentRegexp);
            return r.Match(stringToTest).Success;
        }

    }
}
