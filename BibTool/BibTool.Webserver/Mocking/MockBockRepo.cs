using BibTool.Data.Models;
using BibTool.Webserver.Repositories;

namespace BibTool.Webserver.Mocking;

public class MockBockRepo : IBookRepo
{
    public void AddBook(Book book)
    {
        Console.WriteLine("Added book: " + book);
    }

    public List<Book> GetAllBooks()
    {
        return new List<Book>()
        {
            new Book()
            {
                Title = "Harry Potter",
                Author = "J.K. Rowling",
                Isbn = "1234567890",
                Publisher = "Carlsen",
                ReleaseDate = new DateOnly(1997, 6, 26),
                Stock = 10
            },
            new Book()
            {
                Title = "Harry Potter 2",
                Author = "J.K. Rowling",
                Isbn = "1234567890",
                Publisher = "Carlsen",
                ReleaseDate = new DateOnly(1998, 6, 26),
                Stock = 10
            },
            new Book()
            {
                Title = "Harry Potter 3",
                Author = "J.K. Rowling",
                Isbn = "1234567890",
                Publisher = "Carlsen",
                ReleaseDate = new DateOnly(1999, 6, 26),
                Stock = 10
            },
        };
    }

    public void DeleteBook(Book book)
    {
        Console.WriteLine("Deleted book: " + book);
    }

    public void UpdateBook(Book book)
    {
        Console.WriteLine("Updated book: " + book);
    }
}