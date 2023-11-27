using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibTool.Data.Context;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
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





//    var parent = modelBuilder.Entity<Parent>();
//    parent.HasKey(a => a.Id);
//     parent.Property(a => a.ParentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
//    parent.HasMany(a => a.Logs); //ParentLog

//     var child = modelBuilder.Entity<Child>();
//    child.HasKey(a => new { a.Id, a.ParentId
//});
//     child.Property(a => a.ChildId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
//child.HasRequired(a => a.Parent).WithMany(a => a.Childs).HasForeignKey(a => a.ParentId);

//var childLog = modelBuilder.Entity<ChildLog>();
//childLog.HasKey(a => new { a.Id, a.ChildId, a.ParentId });
//childLog.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
//childLog.HasRequired(a => a.Child).WithMany(a => a.Logs).HasForeignKey(a => new { a.ChildId, a.ParentId });
}
