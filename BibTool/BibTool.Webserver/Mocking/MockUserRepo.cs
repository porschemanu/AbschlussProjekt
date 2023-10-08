using BibTool.Data.Models;
using BibTool.Webserver.Interface;

namespace BibTool.Webserver.Mocking;

public class MockUserRepo : IUserRepo
{
    public User? Login(string username, string password)
    {
        return new User()
        {
            Username = username,
            Password = password,
        };
    }

    public void Register(string username, string password)
    {
        Console.WriteLine("Created new user with username: " + username + " and password: " + password);
    }

    public List<User> GetAllUsers()
    {
        return new List<User>()
        {
            new User()
            {
                Username = "TestUser",
                Password = "TestPassword",
            },
            new User()
            {
                Username = "Manuel Yates",
                Password = "TestPassword",
            },
            new User()
            {
                Username = "Luis Koehl",
                Password = "TestPassword",
            }
        };
    }
}