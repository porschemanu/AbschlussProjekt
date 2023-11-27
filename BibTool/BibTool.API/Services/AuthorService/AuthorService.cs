using BibTool.Data.Context;
using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BibTool.API.Services.AuthorService
{
    public class AuthorService : IAuthorService
    {
        private readonly BibToolContext context;

        public AuthorService(BibToolContext context)
        {
            this.context = context;
        }

        public async Task<Author?> CreateAuthor(Author author)
        {
            try
            {
                context.Add(author);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return author;
        }

        public async Task<Author?> DeleteAuthor(int id)
        {
            Author author = new() { AuthorId = id };

            try
            {
                context.Authors.Attach(author);
                context.Authors.Remove(author);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return author;
        }

        public async Task<Author?> ReadAuthor(int id)
        {
            var author = await context.Authors.FindAsync(id);

            if (author == null) return null;

            return author;
        }

        public async Task<List<Author>> ReadAuthors()
        {
            var authors = await context.Authors.ToListAsync();
            return authors;
        }

        public async Task<Author?> UpdateAuthor(int id, Author author)
        {
            var result = await context.Authors.FindAsync(id);

            if (result == null) return null;

            try
            {
                result.FirstName= author.FirstName;
                result.LastName= author.LastName;
                result.DateOfBirth = author.DateOfBirth;
                result.DateOfDeath = author.DateOfDeath;

                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return result;
        }
    }
}
