using BibTool.Data.Models;
using BibTool.Webserver.Interface;

namespace BibTool.Webserver.Mocking;

public class MockStockRepo : IStockRepo
{
    public int GetBookStock(Book book)
    {
        return 10;
    }

    public void UpdateBookStock(Book book, int count)
    {
        Console.WriteLine("Updated stock of book: " + book.Title + " to: " + count);
    }
}