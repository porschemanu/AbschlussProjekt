using BibTool.Data.Models;

namespace BibTool.API.Services.BookService
{
    public interface IBookService
    {
        Task<List<Book>> ReadBooks();
        Task<Book?> ReadBook(int id);
        Task<Book?> CreateBook(Book book);
        Task<Book?> UpdateBook(int id, Book book);
        Task<Book?> DeleteBook(int id);
    }
}
