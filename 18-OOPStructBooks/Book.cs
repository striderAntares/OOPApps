using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPStructBooks
{
    internal struct Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string ISBNNumber { get; set; }
        public string AuthorName { get; set; }
        public Book(int bookID, string bookName, string bookGenre, string isbnNumber, string authorName) //in structs you can't have constructors without valueless properties.
        {
            BookID = bookID;
            BookName = bookName;
            BookGenre = bookGenre;
            ISBNNumber = isbnNumber;
            AuthorName = authorName;
        }
        //you can also do this:
        public Book()
        {
            BookID = 1;
            BookName = "Nutuk";
            BookGenre = "Memoir";
            ISBNNumber = "01-001NMMKA";
            AuthorName = "MKA";
        }
        //but you can't leave any property unassigned. you can combine these two methods also. you will have some parameters, forcing user to assign them while their instance being taken, you can assign the rest by hand in here.
    }
}
