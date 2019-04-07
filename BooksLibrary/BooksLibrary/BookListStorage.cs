using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BooksLibrary
{
    public class BookListStorage
    {
        private string fileName;

        public BookListStorage(string fileName)
        {
            this.fileName = fileName;
        }

        public void SaveDataToFile(BookCollection books)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (var book in books)
                {
                    writer.Write(book.ISBN);
                    writer.Write(book.Author);
                    writer.Write(book.Name);
                    writer.Write(book.Publisher);
                    writer.Write(book.Year);
                    writer.Write(book.Pages);
                    writer.Write(book.Price);
                }
            }
        }

        public BookCollection LoadDataFromFile()
        {
            var result = new List<Book>();

            if (File.Exists(this.fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(this.fileName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        result.Add(new Book(
                            reader.ReadString(),
                            reader.ReadString(),
                            reader.ReadString(),
                            reader.ReadString(),
                            reader.ReadInt16(),
                            reader.ReadInt16(),
                            reader.ReadDecimal()
                        ));
                    }
                }
            }

            return new BookCollection(result);
        }
    }
}
