using BibTool.Data.Models;
using BibTool.Webserver.Interface;

namespace BibTool.Webserver.Repositories;

public class StockRepo : IStockRepo
{
    public int GetBookStock(Book book)
    {
        throw new NotImplementedException();
    }

    public void UpdateBookStock(Book book, int count)
    {
        throw new NotImplementedException();
    }
}