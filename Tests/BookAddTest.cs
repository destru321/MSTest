using Zajecia;

namespace TestProject
{
    [TestClass]
    public class BookAddTest
    {
        [TestMethod]
        public void BookAddToListTest()
        {
            //Arrange
            Book book = new Book { Title = "LoremIpsum", Author = "Ipsum Lorem", Year = 0000 };
            Library library = new Library();

            //Act
            library.AddBook(book);

            //Assert
            Assert.IsTrue(library.books.Contains(book));
        }
    }
}
