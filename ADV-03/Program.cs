namespace ADV_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01-c
            //c)	Anonymous Method (GetISBN).
            Book book = new Book("123456789", "Sample Title", new[] { "Author One", "Author Two" }, DateTime.Now, 500);

            LIbraryEngine.ProcessBooks(book, delegate (Book b) { return b.ISBN; });
            #endregion

            #region Q01-d
            //d)	Lambda Expression (GetPublicationDate).

            LIbraryEngine.ProcessBooks(book, b => b.PublicationDate.ToShortDateString());
            #endregion

            ///PART02---------------------------------
            ///2.We need to Implement the List methods from scratch with all overloads.
            ///
            List<int> NUmbers =Enumerable.Range(1,100).ToList();
            #region ●Exist

            #endregion
           



        }
    }
}
