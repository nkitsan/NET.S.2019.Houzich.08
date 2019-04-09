using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BooksLibrary
{
    public class BookListStorage
    {
        private static string fileName = "test.txt";
        private static BookListStorage instance;

        public static BookListStorage GetInstance()
        {
            if (instance == null)
            {
                instance = new BookListStorage();
            }
            return instance;
        }

        private BookListStorage()
        { }

        public void SaveDataToFile(BookCollection books)
        {
            using (var writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (var book in books)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        var serializer = new DataContractJsonSerializer(typeof(Book));
                        serializer.WriteObject(memoryStream, book);
                        memoryStream.Position = 0;
                        using (var streamReader = new StreamReader(memoryStream))
                        {
                            writer.Write(streamReader.ReadToEnd());
                        }
                    }
                }
            }
        }

        public BookCollection LoadDataFromFile()
        {
            var result = new List<Book>();

            if (File.Exists(fileName))
            {
                using (var reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string stringBook = reader.ReadString();
                        using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(stringBook)))
                        {
                            var deserializer = new DataContractJsonSerializer(typeof(Book));
                            var book = (Book)deserializer.ReadObject(memoryStream);
                            result.Add(book);
                        }
                    }
                }
            }

            return new BookCollection(result);
        }
    }
}
