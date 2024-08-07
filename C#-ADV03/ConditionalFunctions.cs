using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV03
{
    internal class ConditionalFunctions
    {
        public static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool IsDivisableBy7(int num)
        {
            return num % 7 == 0;
        }

        public static bool IsDivisableBy10(int num)
        {
            return num % 10 == 0;
        }

        public static bool NamesLess4Char(string name)
        {
            return name?.Length < 4;
        }
    }
}
