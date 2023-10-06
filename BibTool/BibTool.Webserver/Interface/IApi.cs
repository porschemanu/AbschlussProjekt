using BibTool.Data.Models;

namespace BibTool.Webserver.Interface;

public interface IApi
{

    #region UserManagement

    public User Login(string username, string password);
    
    public User Register(string username, string password);
    
    public List<User> GetAllUsers();

    #endregion

    #region BookManagement

    public void AddBook(Book book);
    
    public void GetAllBooks();
    
    public void DeleteBook(Book book);
    
    public void UpdateBook(Book book);

    #endregion

    #region BorrowedBookManagement

    public void AddBorrowedBook(Book book, User user);

    #endregion

    

    
  
    
    public void GetAllBorrowedBooks();
    
    public void ReturnBorrowedBook(Book book, User user);

    public List<Book> GetAllOverdueBooks();
    
    public int GetBookStock(Book book);
    
    public void UpdateBookStock(Book book, int count);
    
    
}