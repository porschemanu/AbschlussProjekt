using BibTool.Data.Models;

namespace BibTool.Webserver.Interface;

public interface IStockRepo
{
    public int GetBookStock(Book book);
    
    public void UpdateBookStock(Book book, int count);
}