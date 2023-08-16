using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("Books")]
public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        var books = new List<BookViewModel>()
        {
            new BookViewModel( isbn: "9780356503820",
            title: "The Eye Of The World",
            coverUrl: "https://m.media-amazon.com/images/I/51nDTUXFvaL._SX316_BO1,204,203,200_.jpg",
            authors: new List<AuthorViewModel>(){
                new AuthorViewModel(
                    authorId: 1,
                    name:  "Robert Jordan",
                    photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
                    dateOfBirth: "17 October 1948",
                    biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel.")
        }),

             new BookViewModel( isbn: "9780356503820",
            title: "The Eye Of The World",
            coverUrl: "https://m.media-amazon.com/images/I/51nDTUXFvaL._SX316_BO1,204,203,200_.jpg",
            authors: new List<AuthorViewModel>(){
                new AuthorViewModel(
                    authorId: 1,
                    name:  "Robert Jordan",
                    photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
                    dateOfBirth: "17 October 1948",
                    biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel.")
        }),
            new BookViewModel( isbn: "9780356503820",
            title: "The Eye Of The World",
            coverUrl: "https://m.media-amazon.com/images/I/51nDTUXFvaL._SX316_BO1,204,203,200_.jpg",
            authors: new List<AuthorViewModel>(){
                new AuthorViewModel(
                    authorId: 1,
                    name:  "Robert Jordan",
                    photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
                    dateOfBirth: "17 October 1948",
                    biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel.")
        })


        };
        return View(books);

    }

    [HttpGet("Book")]
    public IActionResult Book()
    {
        var book = new BookViewModel(
            isbn: "9780356503820",
            title: "The Eye Of The World",
            coverUrl: "https://m.media-amazon.com/images/I/51nDTUXFvaL._SX316_BO1,204,203,200_.jpg",
            authors: new List<AuthorViewModel>(){
                new AuthorViewModel(
                    authorId: 1,
                    name:  "Robert Jordan",
                    photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
                    dateOfBirth: "17 October 1948",
                    biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel."),
                }
        );
        return View(book);
    }



}
