using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace BibTool.Data.Models;

public class Book
{
    public int BookId { get; set; }
    public int Isbn { get; set; }
    public string Title { get; set; } = "";
    public string Publisher { get; set; } = "";
    public DateTime ReleaseDate { get; set; } = DateTime.MinValue;

    // 1..n : Author..Book
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;

    // 1..n : Book..BookCopy
    public ICollection<BookCopy> BookCopies { get; } = new List<BookCopy>();
}
