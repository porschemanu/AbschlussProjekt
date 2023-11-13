using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace BibTool.Data.Context;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

public class BibToolContext : DbContext
{
    public BibToolContext(DbContextOptions<BibToolContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCopy> BookCopies { get; set; }
    public DbSet<User> Users { get; set; }
}
