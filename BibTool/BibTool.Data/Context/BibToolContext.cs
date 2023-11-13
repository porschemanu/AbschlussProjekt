using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace BibTool.Data.Context;

public class BibToolContext : DbContext
{
    public BibToolContext(DbContextOptions<BibToolContext> options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer();
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BibToolV1;Trusted_Connection=true;TrustServerCertificate=true;", b => b.MigrationsAssembly("BibTool.API"));
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCopy> BookCopies { get; set; }
    public DbSet<User> Users { get; set; }
}
