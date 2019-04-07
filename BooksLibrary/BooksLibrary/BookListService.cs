using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksLibrary
{
    public class BookListService
    {
        private BookCollection books;

        public BookListService(BookCollection books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            if (this.books.Contains(book))
            {
                throw new ArgumentException("Book collection must not contain book to add");
            }
            this.books.AddBook(book);
        }

        public void RemoveBook(Book book)
        {
            if (!this.books.Contains(book))
            {
                throw new ArgumentException("Book collection must contain book to remove");
            }
            this.books.RemoveBook(book);
        }

        public List<Book> FindBookByISBN(string isbn)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.ISBN == isbn)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByAuthor(string author)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Author == author)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByName(string name)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Name == name)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByPublisher(string publisher)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Publisher == publisher)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByYear(short year)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Year == year)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByPages(short pages)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Pages == pages)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindBookByPrice(decimal price)
        {
            var result = new List<Book>();
            foreach (var book in this.books)
            {
                if (book.Price == price)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public IEnumerable<Book> SortBooksByISBN()
        {
            return this.books.OrderBy(book => book.ISBN);
        }

        public IEnumerable<Book> SortBooksByAuthor()
        {
            return this.books.OrderBy(book => book.Author);
        }

        public IEnumerable<Book> SortBooksByName()
        {
            return this.books.OrderBy(book => book.Name);
        }

        public IEnumerable<Book> SortBooksByPublisher()
        {
            return this.books.OrderBy(book => book.Publisher);
        }

        public IEnumerable<Book> SortBooksByYear()
        {
            return this.books.OrderBy(book => book.Year);
        }

        public IEnumerable<Book> SortBooksByPages()
        {
            return this.books.OrderBy(book => book.Pages);
        }

        public IEnumerable<Book> SortBooksByPrice()
        {
            return this.books.OrderBy(book => book.Price);
        }
    }
}
