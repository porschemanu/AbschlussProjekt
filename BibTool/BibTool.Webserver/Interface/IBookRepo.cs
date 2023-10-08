using BibTool.Data.Models;

namespace BibTool.Webserver.Interface;

public interface IBookRepo
{
    public void AddBook(Book book);

    public List<Book> GetAllBooks();

    public void DeleteBook(Book book);

    public void UpdateBook(Book book);
}