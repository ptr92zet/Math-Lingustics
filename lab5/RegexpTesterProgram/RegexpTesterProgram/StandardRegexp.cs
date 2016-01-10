using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RegexpTesterProgram
{
    public static class StandardRegexp
    {
        public static string IPv4Regexp()
        {
            return "^0*(25[0-5]|2[0-4]\d|1?\d\d?)(\.0*(25[0-5]|2[0-4]\d|1?\d\d?)){3}$";
        }

        public static string SubnetMaskRegexp()
        {
            return "";
        }

        public static string MACAddressRegexp()
        {
            return "";
        }

        public static string EmailAddressRegexp()
        {
            return "";
        }

        public static string IntegersAdditionRegexp()
        {
            return "";
        }

        public static string ComplexNumbersSubtractionRegexp()
        {
            return "";
        }

        public static string HTMLTextFormatMarkupsRegexp()
        {
            return "";
        }

        public static string HTMLTableMarkupsRegexp()
        {
            return "";
        }
    }
}
