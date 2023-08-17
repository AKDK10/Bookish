namespace Bookish.Models;

public class AuthorViewModel
{
     public class AuthorBookViewModel
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }

        public AuthorBookViewModel(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }
    }
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? DateOfBirth { get; set; }
    public string? PhotoUrl { get; set; }
    public string? Biography { get; set; }
    public List<BookViewModel>? Books { get; set; }

    public AuthorViewModel(int authorId, string name, string photoUrl, string dateOfBirth, string biography)
    {
        Id = authorId;
        Name = name;
        PhotoUrl = photoUrl;
        DateOfBirth = dateOfBirth;
        Biography = biography;
    }



}
