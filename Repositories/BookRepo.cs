using Bookish;
using Bookish.Models.Database;

using Microsoft.EntityFrameworkCore;

public interface IBookRepo
{
    List<BookModel> GetAllBooks();
    BookModel GetBookByIsbn(string isbn);
}

public class BookRepo : IBookRepo
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
        return _context.Books.Include(b => b.Authors).Where(b => b.Isbn == isbn).Single();
    }
}