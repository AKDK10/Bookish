using Microsoft.EntityFrameworkCore;

namespace Bookish.Models;


public class AuthorModel
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? DateOfBirth { get; set; }
    public string? PhotoUrl { get; set; }
    public string? Biography { get; set; }
    public List<BookModel>? Books { get; set; }

}

