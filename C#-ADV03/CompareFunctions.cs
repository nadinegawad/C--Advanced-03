using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV03
{
    internal class CompareFunctions
    {
        public static bool CompareGrt(int a,int b)
        {
            return a > b;
        }

        public static bool CompareLess(int a, int b)
        {
            return a < b;
        }

        public static bool SortAsce(string x,string y)
        {
            return x?.Length > y?.Length;
        }

        public static bool SortDesc(string x, string y)
        {
            return x?.Length < y?.Length;
        }
    }
}
