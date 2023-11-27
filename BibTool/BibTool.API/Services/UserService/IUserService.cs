using BibTool.Data.Models;

namespace BibTool.API.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> ReadUsers();
        Task<User?> ReadUser(int id);
        Task<User?> CreateUser(User user);
        Task<User?> UpdateUser(int id, User user);
        Task<User?> DeleteUser(int id);
    }
}
