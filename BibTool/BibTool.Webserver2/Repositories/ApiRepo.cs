using BibTool.Data.Models;
using BibTool.Webserver2.Interfaces;

namespace BibTool.Webserver2.Repositories;

public class ApiRepo : IDataRepo
{
    private HttpClient _client = new();
    private const string ApiUrl = "https://localhost:5001/api/";
    
    public async Task<bool> Login(string username, string password)
    {
        var u = await _client.PostAsync($"{ApiUrl}user/login?username={username}&password={password}", null);
        return u.IsSuccessStatusCode;
    }

    public async Task<bool> Register(User user)
    {
        var r = await _client.PostAsJsonAsync($"{ApiUrl}/user/register", user);
        return r.IsSuccessStatusCode;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var u = await _client.GetFromJsonAsync<List<User>>($"{ApiUrl}user/getall");
        return u ?? new List<User>();
    }

    public async Task<bool> AddBook(Book book)
    {
        var r = await _client.PostAsJsonAsync($"{ApiUrl}/books/add", book);
        return r.IsSuccessStatusCode;
    }

    public async Task<List<Book>> GetAllBooks()
    {
        var b = await _client.GetFromJsonAsync<List<Book>>($"{ApiUrl}book/getall");
        return b ?? new List<Book>();
    }

    public async Task<bool> DeleteBook(Book book)
    {
        var r = await _client.DeleteAsync($"{ApiUrl}book/delete/{book.BookId}");
        return r.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateBook(Book book)
    {
        var r = await _client.PatchAsJsonAsync($"{ApiUrl}/user/register", book);
        return r.IsSuccessStatusCode;
    }

    public async Task<List<Book>> GetAllOverdueBooks()
    {
        var b = await _client.GetFromJsonAsync<List<Book>>($"{ApiUrl}book/getalloverdue");
        return b ?? new List<Book>();
    }

    public async Task<bool> AddBorrowedBook(Book book, User user)
    {
        var r = await _client.PostAsync($"{ApiUrl}books/borrow?bookid={book.BookId}&userid={user.UserId}", null);
        return r.IsSuccessStatusCode;
    }

    public async Task<List<Book>> GetAllBorrowedBooks()
    {
        var b = await _client.GetFromJsonAsync<List<Book>>($"{ApiUrl}book/getallborrowed");
        return b ?? new List<Book>();
    }

    public async Task<bool> ReturnBorrowedBook(Book book, User user)
    {
        var r = await _client.PostAsync($"{ApiUrl}books/return?bookid={book.BookId}&userid={user.UserId}", null);
        return r.IsSuccessStatusCode;
    }

    public async Task<int> GetBookStock(Book book)
    {
        return await _client.GetFromJsonAsync<int>($"{ApiUrl}book/getstock/{book.BookId}");
    }

    public async Task<bool> UpdateBookStock(Book book, int count)
    {
        var r = await _client.PatchAsJsonAsync($"{ApiUrl}/book/update?bookid={book.BookId}", count);
        return r.IsSuccessStatusCode;
    }
}