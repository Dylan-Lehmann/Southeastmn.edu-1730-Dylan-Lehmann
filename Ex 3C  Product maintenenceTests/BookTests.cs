namespace Ex_3C__Product_maintenence.Tests
{
    [TestClass()]
    public class BookTests
    {
        Book book = new Book("ABC", "New Software", 55.9m, "Tom");
        [TestMethod()]
        public void BookTest()
        {
            Assert.IsNotNull(book);
            Assert.IsNotNull(book.Description);
            Assert.IsNotNull(book.Author);
            Assert.IsNotNull(book.Price);
            Assert.IsNotNull(book.Code);
            Assert.AreEqual(book.Code, "ABC");
            Assert.AreEqual(book.Description, "New Software");
            Assert.AreEqual(book.Price, 55.9m);
            Assert.AreEqual(book.Author, "Tom");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(book.ToString(), "ABC\t55.90\tNew Product\tTom");
        }
    }
}