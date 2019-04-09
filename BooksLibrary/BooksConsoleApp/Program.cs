using System;
using BooksLibrary;

namespace BooksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookListStorage = BookListStorage.GetInstance();
            var books = bookListStorage.LoadDataFromFile();
            var bookListService = new BookListService(books);

            foreach (var book in bookListService.SortBooksByPrice())
            {
                Console.WriteLine(book);
                Console.WriteLine("--------------------------------");
            }

            Console.ReadKey();
        }
    }
}
