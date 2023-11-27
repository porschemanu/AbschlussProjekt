using BibTool.Data.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace BibTool.API.Services.AuthorService
{
    public interface IAuthorService
    {
        Task<List<Author>> ReadAuthors();
        Task<Author?> ReadAuthor(int id);
        Task<Author?> CreateAuthor(Author author);
        Task<Author?> UpdateAuthor(int id, Author author);
        Task<Author?> DeleteAuthor(int id);
    }
}
