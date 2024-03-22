using System;
using System.Collections.Generic;

namespace BookLibrary
{
    public class Library
    {
        public string name;
        List<Book> books = new List<Book>();

        public void AddBook (Book book)
        {
            books.Add(book);
        }
        public void SearchBook (string author)
        {
            foreach (var book in books)
            {
                if (book.author.Contains(author))
                {
                    Console.WriteLine("BOOK FOUND...");
                    DisplayBookInfo(book);
                }
              
            }
        }

        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine("BOOK INFORMATION in " + name + "...");
            Console.WriteLine("TITLE: " + book.title);
            Console.WriteLine("AUTHOR: " + book.author);
            Console.WriteLine("PUBLISHER: " + book.publisher);
            Console.WriteLine("ISBN: " + book.ISBN);
            Console.WriteLine("-------------------");
        }
        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }
    }
}
