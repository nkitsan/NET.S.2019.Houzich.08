using NUnit.Framework;
using BooksLibrary;

namespace Tests
{
    public class BooksLibraryTests
    {
        private Book book;

        [SetUp]
        public void Setup()
        {
            book = new Book("9785170996261",
                                "King",
                                "Pet Sematary",
                                "AST",
                                2016,
                                480,
                                8.0m);
        }

        [TestCase(StringFormEnum.Short, "King, Pet Sematary")]
        [TestCase(StringFormEnum.ShortAndPublisher, "King, Pet Sematary, AST, 2016")]
        [TestCase(StringFormEnum.Full, "9785170996261, King, Pet Sematary, AST, 2016, P.480")]
        [TestCase(StringFormEnum.FullWithPrice, "9785170996261, King, Pet Sematary, AST, 2016, P.480, 8,0$")]
        public void StringBookRepresentationTest(StringFormEnum form, string expected)
        {
            Assert.AreEqual(expected, book.ToString(form));
        }
    }
}