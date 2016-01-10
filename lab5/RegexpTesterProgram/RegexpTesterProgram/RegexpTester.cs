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

        //public string CurrentString { get; set; }

        private List<string> StandardRegexps;
        private List<string> stringsToTest;

        public bool Test(string stringToTest)
        {
            Regex r = new Regex(CurrentRegexp);
            return r.Match(stringToTest).Success;
        }

        public void SetStringsToTest(string fileContent)
        {
            string[] stringTokens = fileContent.Split(';');
            foreach (string s in stringTokens)
            {
                s.Trim('\n');
            }
            this.stringsToTest = new List<string>(stringTokens);
        }

        //public string GetStringsToTest()
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (string str in this.stringsToTest)
        //    {
        //        builder.Append(str);
        //    }
        //    return builder.ToString();
        //}

        public string[] GetStringsToTest()
        {
            return this.stringsToTest.ToArray();
        }

    }
}
