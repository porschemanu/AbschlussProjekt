using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BibTool.Data.Context;

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
