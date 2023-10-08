namespace BibTool.Data.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Publisher { get; set; } = "";
    public string Isbn { get; set; } = "";
    public DateOnly ReleaseDate { get; set; } = DateOnly.MinValue;
    public int Stock { get; set; } = 0;
}