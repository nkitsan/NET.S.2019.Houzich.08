using System;
using System.Runtime.Serialization;

namespace BooksLibrary
{
    [DataContract]
    public class Book : IComparable<Book>, IEquatable<Book>
    {
        [DataMember]
        public string ISBN { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Publisher { get; set; }

        [DataMember]
        public short Year { get; set; }

        [DataMember]
        public short Pages { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        private static string isbnPrefics = "978";

        public Book(string isbn, string author, string name, string publisher, short year, short pages, decimal price)
        {
            if (!isbn.StartsWith(isbnPrefics))
            {
                throw new ArgumentException("ISBN must start from prefix 978");
            }

            foreach(var c in isbn)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("ISBN must consist only digits");
                }
            }

            this.ISBN = isbn;
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
            this.Year = year;
            this.Pages = pages;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {this.ISBN}\nAuthor: {this.Author}\nName: {this.Name}\nPublisher: {this.Publisher}\n" +
                    $"Year: {this.Year}\nPages: {this.Pages}\nPrice: {this.Price}";
        }

        public int CompareTo(Book other)
        {
            if (other == null)
            {
                return -1;
            }

            if (other.Author == this.Author)
            {
                if (other.Name == this.Name)
                {
                    return 0;
                }
                else
                {
                    return this.Name.CompareTo(other.Name);
                }
            }

            return this.Author.CompareTo(other.Author);
        }

        public bool Equals(Book other)
        {
            if (other == null)
            {
                return false;
            }

            if (other.ISBN == this.ISBN && 
                other.Author == this.Author && 
                other.Name == this.Name &&
                other.Publisher == this.Publisher && 
                other.Year == this.Year &&
                other.Pages == this.Pages &&
                other.Price == this.Price)
            {
                return true;
            }

            return false;
        }
    }
}
