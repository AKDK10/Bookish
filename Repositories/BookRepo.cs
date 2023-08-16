using Bookish;
using Bookish.Models;
using Bookish.Models.Database;

using Microsoft.EntityFrameworkCore;

public class BookRepo
{
    private readonly BookishContext _context;

    public BookRepo(BookishContext context)
    {
        _context = context;

    }

    public List<BookModel> GetAllBooks()
    {
        return _context.Books
        .Include(b => b.Authors)
        .ToList();
    }

    public BookModel GetBookByIsbn(string isbn)
    {
        return _context.Books.Where(b => b.Isbn == isbn).Single();
    }
}