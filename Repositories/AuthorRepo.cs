using Bookish;
using Bookish.Models.Database;

using Microsoft.EntityFrameworkCore;

public interface IAuthorRepo
{
    List<AuthorModel> GetAllAuthors();
    AuthorModel GetAuthorById(int Id);
}

public class AuthorRepo : IAuthorRepo
{
    private readonly BookishContext _context;
    public AuthorRepo(BookishContext context)
    {
        _context = context;
    }

    public List<AuthorModel> GetAllAuthors()
    {
        return _context.Authors
        .Include(a => a.Books)
        .ToList();
    }

    public AuthorModel GetAuthorById(int Id)
    {
        return _context.Authors.Include(a => a.Books).Where(a => a.Id == Id).Single();
    }
}