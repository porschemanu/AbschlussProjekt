using BibTool.Data.Models;

namespace BibTool.Webserver.Interface;

public interface IUserRepo
{
    public User? Login(string username, string password);

    public void Register(string username, string password);
    
    public List<User> GetAllUsers();
}