using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_03
{

   

    internal class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthors(Book b)
        {
            throw new NotImplementedException();
        }

        public static string GetPrice(Book b)
        {
            return b.Price.ToString();
        }
    }
}
