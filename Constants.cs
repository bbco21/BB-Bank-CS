using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_Bank
{
    internal class Constants
    {
        public const string TesztStr = "Konstans teszt sztring.";
        public const string BANNER = "------------------------------------\nBB Bank\n";
        public const string PHASE = "ALPHA";
        public const string VERSION = "1.0.0";

        public const string MESSAGE = BANNER + PHASE + " " + VERSION + "\n";

        public const int MIN_PLAYERS = 2;
        public const int MIN_MONEY = 0;
        public const int START_MONEY = 20000000;

        public static string RemoveSpaces(string stringToModify)
        {
            stringToModify = stringToModify.Replace(" ", "[]");
            return stringToModify;
        }

        public static string SpacesBack(string stringToModify)
        {
            stringToModify = stringToModify.Replace("[]", " ");
            return stringToModify;
        }
    }
}
