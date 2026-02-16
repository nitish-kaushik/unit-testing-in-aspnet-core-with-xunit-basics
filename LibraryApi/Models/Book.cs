namespace LibraryApi.Models;

public class Book
{
    public int Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
    public DateTime PublishedDate { get; set; }
}
