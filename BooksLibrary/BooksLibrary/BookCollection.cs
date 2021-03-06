﻿using System.Collections;
using System.Collections.Generic;

namespace BooksLibrary
{
    public class BookCollection : IEnumerable<Book>
    {
        private List<Book> books;

        public BookCollection(List<Book> books)
        {
            this.books = books;
        }

        public bool Contains(Book book)
        {
            return this.books.Contains(book);
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            this.books.Remove(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.books.GetEnumerator();
        }
    }
}
