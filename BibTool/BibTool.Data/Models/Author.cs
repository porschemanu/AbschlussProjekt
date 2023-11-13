using System.ComponentModel.DataAnnotations;

namespace BibTool.Data.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    public DateTime DateOfDeath { get; set; } = DateTime.MinValue;

    // 1..n : Author..Book
    public ICollection<Book> Books { get; } = new List<Book>();
}
