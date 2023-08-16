namespace Bookish.Models;

public class AuthorViewModel
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string? DateOfBirth { get; set; }
    public string? PhotoUrl { get; set; }
    public string? Biography { get; set; }


    public AuthorViewModel(int authorId, string name, string photoUrl, string dateOfBirth, string biography)
    {
        AuthorId = authorId;
        Name = name;
        PhotoUrl = photoUrl;
        DateOfBirth = dateOfBirth;
        Biography = biography;
    }



}
