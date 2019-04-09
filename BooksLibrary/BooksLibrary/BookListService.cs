using System;
using System.Collections.Generic;
using System.Linq;

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
                throw new ArgumentException("Book collection must not contain a book to add");
            }
            this.books.AddBook(book);
        }

        public void RemoveBook(Book book)
        {
            if (!this.books.Contains(book))
            {
                throw new ArgumentException("Book collection must contain a book to remove");
            }
            this.books.RemoveBook(book);
        }

        private IEnumerable<Book> FindBooksByTag(FieldEnum field, string value)
        {
            foreach (var book in this.books)
            {
                if ((field == FieldEnum.ISBN && book.ISBN == value) ||
                   (field == FieldEnum.Author && book.Author == value) ||
                   (field == FieldEnum.Name && book.Name == value) ||
                   (field == FieldEnum.Publisher && book.Publisher == value) ||
                   (field == FieldEnum.Year && book.Year == short.Parse(value)) ||
                   (field == FieldEnum.Pages && book.Pages == short.Parse(value)) ||
                   (field == FieldEnum.Price && book.Price == decimal.Parse(value)))
                {
                    yield return book;
                }
            }
        }

        public List<Book> FindBooksByISBN(string isbn)
        {
            return FindBooksByTag(FieldEnum.ISBN, isbn).ToList();
        }

        public List<Book> FindBooksByAuthor(string author)
        {
            return FindBooksByTag(FieldEnum.Author, author).ToList();
        }

        public List<Book> FindBooksByName(string name)
        {
            return FindBooksByTag(FieldEnum.Name, name).ToList();
        }

        public List<Book> FindBooksByPublisher(string publisher)
        {
            return FindBooksByTag(FieldEnum.Publisher, publisher).ToList();
        }

        public List<Book> FindBooksByYear(short year)
        {
            return FindBooksByTag(FieldEnum.Year, year.ToString()).ToList();
        }

        public List<Book> FindBooksByPages(short pages)
        {
            return FindBooksByTag(FieldEnum.Pages, pages.ToString()).ToList();
        }

        public List<Book> FindBooksByPrice(decimal price)
        {
            return FindBooksByTag(FieldEnum.Price, price.ToString()).ToList();
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
