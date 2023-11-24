using Zajecia;

namespace TestProject
{
    [TestClass]
    public class CheckDisplay
    {
        [TestMethod]
        public void CheckIfDisplayIsCorrect()
        {
            //Arrange
            Book book = new Book { Title = "LoremIpsum", Author = "Ipsum Lorem", Year = 0000 };
            Library library = new Library();

            string expectedOutput = "Library Books:" +
                $"\n{book.Title} by {book.Author} ({book.Year})";

            StringWriter DisplayOutput = new StringWriter();

            //Act
            library.AddBook(book);
            Console.SetOut(DisplayOutput);
            library.DisplayBooks();
            string DisplayResult = DisplayOutput.ToString().Trim();

            //Assert
            Assert.AreEqual(expectedOutput, DisplayResult);
        }
    }
}
