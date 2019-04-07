using System;
using System.Collections.Generic;
using BooksLibrary;

namespace BooksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookCollection(
                new List<Book>
                {
                    new Book("9781107699892", "Murphy", "Advanced Grammar in Use Book", "Cambridge University Press", 2013, 260, 65.0M),
                    new Book("9785170996261", "King", "Pet Sematary", "AST", 2016, 480, 8.0M)
                });

            var bookListService = new BookListService(books);
            var orederedByAuthor = bookListService.SortBooksByAuthor();

            foreach (var b in orederedByAuthor)
            {
                Console.WriteLine(b.ToString());
            }

            Console.ReadKey();
        }
    }
}
