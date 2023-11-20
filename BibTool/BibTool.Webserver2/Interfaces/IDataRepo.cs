using BibTool.Data.Models;

namespace BibTool.Webserver2.Interfaces;

public interface IDataRepo
{
    #region UserManagement

    public Task<bool> Login(string username, string password);

    public Task<bool> Register(User user);
    
    public Task<List<User>> GetAllUsers();

    #endregion

    #region BookManagement

    public Task<bool> AddBook(Book book);

    public Task<List<Book>> GetAllBooks();
    
    public Task<bool> DeleteBook(Book book);
    
    public Task<bool> UpdateBook(Book book);

    #endregion

    #region BorrowedBookManagement
    public Task<List<Book>> GetAllOverdueBooks();
    public Task<bool> AddBorrowedBook(Book book, User user);
    public Task<List<Book>> GetAllBorrowedBooks();
    public Task<bool> ReturnBorrowedBook(Book book, User user);
    #endregion

    #region StockManagement
    public Task<int> GetBookStock(Book book);
    
    public Task<bool> UpdateBookStock(Book book, int count);
    #endregion
}