﻿using System;
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
