using System;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myBestBooksLibrary = new Library();
            myBestBooksLibrary.name = "My recommended books";

            Book top1Book = new Book();
            top1Book.title = "The Alchemist";
            top1Book.author = "Paulo Coelho";
            top1Book.publisher = "some publisher";
            top1Book.releaseDate = new DateTime(1988, 1, 1);
            top1Book.ISBN = "BOOK1231231";

            Book top2Book = new Book();
            {
                top2Book.title = "Harry Potter";
                top2Book.author = "J.K Rowling";
                top2Book.publisher = "some publisher";
                top2Book.releaseDate = new DateTime(1987, 1, 1);
                top2Book.ISBN = "BOOK4564564";
            };

            myBestBooksLibrary.AddBook(top1Book);
            myBestBooksLibrary.AddBook(top2Book);

            myBestBooksLibrary.SearchBook("Rowling");
            myBestBooksLibrary.DisplayBookInfo(top1Book);
           
        }
    }
}
