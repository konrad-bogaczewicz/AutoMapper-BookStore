namespace AutoMapper.BookStore.Services;

using AutoMapper.BookStore.Models;

public interface IBookService
{
    Book GetBookById(int id);

    List<Book> GetBookByTitle(string title);

    Book GetNewestBooksByAuthorName(string authorName);
}
