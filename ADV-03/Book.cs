using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_03
{
    //a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
    public delegate string BookFuncDel(Book b);
    public class Book
    {
        public string ISBN {  get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book() { }
        public Book(string _ISBN,string _title, string[] _authors,DateTime _dateTime,decimal _price)
        {
            ISBN = _ISBN;
            Title = _title;
            Authors = _authors;
            PublicationDate = _dateTime;
            Price = _price;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }


       
    }
}
