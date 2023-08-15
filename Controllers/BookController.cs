using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("Book")]
public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }
    [HttpGet("index")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("Book")]
     public IActionResult Book()
    {   
        var book = new BookViewModel(
            isbn: "9780356503820",
            title:"The Eye Of The World",
            coverUrl: "https://m.media-amazon.com/images/I/51nDTUXFvaL._SX316_BO1,204,203,200_.jpg"
        );
        return View(book);
    }
}
