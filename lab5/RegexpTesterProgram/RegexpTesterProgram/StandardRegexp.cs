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
            return @"^(25[0-5]|2[0-4]\d|1?\d\d?)(\.(25[0-5]|2[0-4]\d|1?\d\d?)){3}$";
        }

        public static string SubnetMaskRegexp()
        {
            return @"^(25[0-5]|2[0-4]\d|1?\d\d?)(\.(25[0-5]|2[0-4]\d|1?\d\d?)){3}$";
        }

        public static string MACAddressRegexp()
        {
            return @"^(([0-9a-fA-F]{2}:){5}[0-9a-fA-F]{2}|([0-9a-fA-F]{2}-){5}[0-9a-fA-F]{2})$";
        }

        public static string EmailAddressRegexp()
        {
            return @"^(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@)(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9])$";
        }

        public static string IntegersAdditionRegexp()
        {
            return @"^-?(0|[1-9][0-9]*)(\+(0|[1-9][0-9]*|\(-(0|[1-9][0-9]*)\)))*$"; // allows 5+3+4, 5+3+(-4), but doesn't allow 5+3-4, eliminates leading 0's
        }

        public static string ComplexNumbersSubtractionRegexp()  // allows: [+-](a[+-]bi)-(c[+-]di), a-d can be double
        {
            return @"^[+-]?"+
                   @"\(((0|[1-9][0-9]*)\.[0-9]+|(0|[1-9][0-9]*))[+-]((0|[1-9][0-9]*)\.[0-9]+|(0|[1-9][0-9]*))i\)" +
                   @"-\(((0|[1-9][0-9]*)\.[0-9]+|(0|[1-9][0-9]*))[+-]((0|[1-9][0-9]*)\.[0-9]+|(0|[1-9][0-9]*))i\)$";
        }

        public static string HTMLTextFormatMarkupsRegexp()
        {
            return @"^(<(?<markup>(p|b|i|u|strong|small|strike|h[1-6]|pre|code|tt|blockquote|font|center))[^>]*>[^<]*</\k<markup>>)+$";
        }

        public static string HTMLTableMarkupsRegexp()
        {
            return @"^(<(?<markup>(table|tr|td))[^>]*>[^<]*</\k<markup>>)+$";
        }
    }
}
