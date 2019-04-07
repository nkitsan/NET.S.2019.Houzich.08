using System;

namespace BooksLibrary
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public short Year { get; set; }
        public short Pages { get; set; }
        public decimal Price { get; set; }
    }
}
