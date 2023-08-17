using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("Authors")]
public class AuthorController : Controller
{
    private readonly IAuthorRepo _authorRepo;
    private readonly ILogger<AuthorController> _logger;

    public AuthorController(IAuthorRepo authorRepo, ILogger<AuthorController> logger)
    {
        _authorRepo = authorRepo;
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        // var authors = new List<AuthorViewModel>()

        // {
        //   new AuthorViewModel(
        //     authorId: 1,
        //     name:  "Robert Jordan",
        //     photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
        //     dateOfBirth: "17 October 1948",
        //     biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel."),

        // new AuthorViewModel(
        //     authorId: 1,
        //     name:  "Robert Jordan",
        //     photoUrl:"https://www.locusmag.com/2006/Issues/03jordan_270x360.jpg",
        //     dateOfBirth: "17 October 1948",
        //     biography: "James Oliver Rigney Jr., better known by his pen name Robert Jordan, was an American author of epic fantasy. He is known best for his series The Wheel of Time which comprises 14 books and a prequel novel."),

        // };

        var authors = _authorRepo.GetAllAuthors().Select(a => new AuthorViewModel(
            id: a.Id.Value,
            name: a.Name,
            photoUrl: a.PhotoUrl,
            dateOfBirth: a.DateOfBirth,
            biography: a.Biography)).ToList();

        return View(authors);

    }

    [HttpGet("Author")]
    public IActionResult Author(int id)
    {
        var author = _authorRepo.GetAuthorById(id);

        var returnAuthor = new AuthorViewModel(
                id: author.Id.Value,
                name: author.Name,
                photoUrl: author.PhotoUrl,
                dateOfBirth: author.DateOfBirth,
                biography: author.Biography);

        return View(returnAuthor);
    }



}
