using BibTool.Data.Models;
using BibTool.Webserver.Interface;

namespace BibTool.Webserver.Repositories;

public class UserRepo : IUserRepo
{
    public User? Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public void Register(string username, string password)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}