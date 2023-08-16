using Microsoft.EntityFrameworkCore;

namespace Bookish.Models;

[PrimaryKey("Isbn")]
public class BookModel
{
    public string? Isbn { get; set; }
    public string? Title { get; set; }
    public string? CoverUrl { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public string? YearPublished { get; set; }
    public List<AuthorModel>? Authors { get; set; }

}
