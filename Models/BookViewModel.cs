namespace Bookish.Models;

public class BookViewModel
{
    public string Isbn { get; set; }
    public string Title { get; set; }
    public string? CoverUrl { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public string? YearPublished { get; set; }
    public List<AuthorViewModel> Authors { get; set; }
    public List<BookCopyViewModel>? Copies { get; set; }


    public BookViewModel(string isbn, string title, string coverUrl, List<AuthorViewModel> authors)
    {
     
        if (Isbn == null || title == null)
        {
            throw new ArgumentNullException("These fields cannot be null");
        }
            Isbn = isbn;
            Title = title;
            CoverUrl = coverUrl;
            Authors = authors;
    }

}
