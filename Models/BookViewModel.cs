using Bookish.Models.Database;

namespace Bookish.Models;

public class BookViewModel
{
    public class BookAuthorViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public BookAuthorViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public string Isbn { get; set; }
    public string Title { get; set; }
    public string? CoverUrl { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public string? YearPublished { get; set; }
    public List<BookAuthorViewModel>? Authors { get; set; }
    public List<BookCopyViewModel>? Copies { get; set; }

    public BookViewModel(string isbn, string title, string coverUrl, List<BookAuthorViewModel> authors)
    {
        Isbn = isbn;
        Title = title;
        CoverUrl = coverUrl;
        Authors = new List<BookAuthorViewModel>();

    }
    public BookViewModel(BookModel book)
    {
        Isbn = book.Isbn;
        Title = book.Title;
        CoverUrl = book.CoverUrl;
        Authors = book.Authors.Select(a => new BookAuthorViewModel(a.Id.Value, a.Name)).ToList();

    }

}
