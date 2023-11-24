using Zajecia;

namespace TestProject
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookValueAddTest()
        {
            //Arrange
            Book book = new();
            string Title = "LoremIpsum";
            string Author = "Ipsum Lorem";
            int Year = 0000;

            //Act
            book.Title = Title;
            book.Author = Author;
            book.Year = Year;

            //Assert
            Assert.IsNotNull(Title);
            Assert.IsNotNull(Author);
            Assert.IsNotNull(Year);
        }
    }
}