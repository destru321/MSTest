using System;
using System.Collections.Generic;

namespace Zajecia
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class Library
    {
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Library Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
            }
        }

        public void RemoveBook(string title)
        {
            Book? book = books.Find(book => book.Title.Contains(title));
            books.Remove(book);
        }
    }

    class Program
    {
        static void Main()
        {
            Library library = new Library();

            // Dodanie kilku książek do biblioteki
            Book book1 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 };
            Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 };
            Book book3 = new Book { Title = "1984", Author = "George Orwell", Year = 1949 };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Wyświetlenie wszystkich książek w bibliotece
            library.DisplayBooks();
        }
    }
}