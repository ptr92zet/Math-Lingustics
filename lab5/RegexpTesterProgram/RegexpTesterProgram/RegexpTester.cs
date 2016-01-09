using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexpTesterProgram
{
    public class RegexpTester : IRegexpTester
    {
        private string currentRegexp;
        private string currentString;

        private List<string> standardRegexps;
        private List<string> stringsToTest;

        public bool Test(string stringToTest)
        {
            return true;
        }

        public void SetStringsToTest(string fileContent)
        {
            string[] stringTokens = fileContent.Split(";\n".ToCharArray());
            this.stringsToTest = new List<string>(stringTokens);
        }

        public string GetStringsToTest()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string str in this.stringsToTest)
            {
                builder.Append(str + "\n");
            }
            return builder.ToString();
        }
    }
}
