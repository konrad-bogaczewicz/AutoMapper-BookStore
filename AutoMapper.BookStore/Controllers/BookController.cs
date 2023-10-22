namespace AutoMapper.BookStore.Controllers;

using AutoMapper.BookStore.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    /// <summary>
    /// Basic Configuration Example.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("{authorName}")]
    public void GetBook(string authorName)
    {
        var book = _bookService.GetNewestBooksByAuthorName(authorName);
    }
}
