using Zajecia;

namespace TestProject
{
    [TestClass]
    public class BookDeleteTest
    {
        [TestMethod]
        public void BookDeleteFromListTest()
        {
            //Arrange
            Book book = new Book { Title = "LoremIpsum", Author = "Ipsum Lorem", Year = 0000 };
            Library library = new Library();

            //Act
            library.AddBook(book);
            library.RemoveBook(book.Title);

            //Assert
            Assert.IsFalse(library.books.Contains(book));
        }
    }
}

