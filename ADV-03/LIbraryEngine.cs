using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_03
{
    internal class LIbraryEngine
    {
        #region Q01-a
        // a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

        //public static void ProcessBooks(List <Book> b, BookFuncDel del)
        //{
        //     foreach(Book book in b)
            //{
            //    Console.WriteLine(del(book));
            //}
    //}
    #endregion

        #region Q01-b
    //b)	Use the Proper build in delegate. 
    public static void ProcessBooks( List <Book> b, Func<Book, string> del)
        {
            foreach(Book book in b)
            {
                Console.WriteLine(del(book));
            }
        }
        #endregion
    }
}
