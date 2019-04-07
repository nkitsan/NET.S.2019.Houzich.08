using System;
using System.Collections.Generic;
using BooksLibrary;

namespace BooksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookListStorage = new BookListStorage("test.txt");
            var books = bookListStorage.LoadDataFromFile();
            var bookListService = new BookListService(books);

            foreach (var book in bookListService.SortBooksByAuthor())
            {
                Console.WriteLine(book);
                Console.WriteLine("--------------------------------");
            }

            Console.ReadKey();
        }
    }
}
