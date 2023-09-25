using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace BibTool.Data.Context;

public class BibToolContext : DbContext
{
    public BibToolContext(DbContextOptions<BibToolContext> options) : base(options)
    {
    }
    
    public DbSet<Book> Books { get; set; }
}