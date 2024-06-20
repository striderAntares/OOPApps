using _18_OOPStructBooks;

Book book = new Book();
Console.WriteLine(book.BookName + " " + book.AuthorName + " " + book.BookGenre + " " + book.ISBNNumber + " " + book.BookID);
book.BookID = 156;
Console.WriteLine(book.BookID);//we can change it.
Book book1 = new Book(2, "Abasıyanık", "Romance", "02-002-SFR","Sait Faik");
Console.WriteLine(book1.BookName + " " + book1.AuthorName + " " + book1.BookGenre + " " + book1.ISBNNumber + " " + book1.BookID);