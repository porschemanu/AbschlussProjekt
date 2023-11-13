using System.ComponentModel.DataAnnotations;

namespace BibTool.Data.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";

    public List<BookCopy> BookCopies { get; set; } = new();
}
