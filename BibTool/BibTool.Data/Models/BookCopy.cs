using System.ComponentModel.DataAnnotations;

namespace BibTool.Data.Models;

public class BookCopy
{
    public int BookCopyId { get; set; }
    public string Status { get; set; } = "";
    public DateTime DueDate { get; set; } = DateTime.MinValue;

    // 1..n : Book..BookCopy
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    // m..n : User..BookCopy
    public List<User> Users { get; set; } = new();
}
