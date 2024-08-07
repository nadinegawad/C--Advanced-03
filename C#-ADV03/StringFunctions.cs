



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV03
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperChars(string _name)
        {
            int Count = 0;
            if (_name is not null)
            {
                for (int i = 0; i < _name.Length; i++)
                {
                    if (char.IsUpper(_name[i]))
                        Count++;
                }
            }
            return Count;
        }

        public static int GetCountOfLowerChars(string _name)
        {
            int Count = 0;
            if (_name is not null)
            {
                for (int i = 0; i < _name.Length; i++)
                {
                    if (char.IsLower(_name[i]))
                        Count++;
                }
            }
            return Count;
        }
    }
}
