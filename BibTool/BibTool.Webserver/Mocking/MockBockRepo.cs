using BibTool.Data.Models;
using BibTool.Webserver.Interface;
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
        return new List<Book>();
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