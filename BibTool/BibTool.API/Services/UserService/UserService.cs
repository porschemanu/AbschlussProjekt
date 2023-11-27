using BibTool.Data.Context;
using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BibTool.API.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly BibToolContext context;

        public UserService(BibToolContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> ReadUsers()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> ReadUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null) return null;

            return user;
        }

        public async Task<User?> CreateUser(User user)
        {
            try
            {
                context.Add(user);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return user;
        }

        // PUT
        //public async Task<User?> UpdateUser(int id, User user)
        //{
        //    var result = await context.Users.FindAsync(id);

        //    if (result == null) return null;

        //    try
        //    {
        //        result.Username = user.Username;
        //        result.Password = user.Password;

        //        await context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        return null;
        //    }

        //    return result;
        //}

        public async Task<User?> UpdateUser(int id, User user)
        {

        }

        public async Task<User?> DeleteUser(int id)
        {
            User user = new() { UserId = id };

            try
            {
                context.Users.Attach(user);
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return user;
        }
    }
}
