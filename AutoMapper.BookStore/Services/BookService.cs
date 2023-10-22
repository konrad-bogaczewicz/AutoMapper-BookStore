namespace AutoMapper.BookStore.Services;

using AutoMapper.BookStore.Models;

public class BookService : IBookService
{
    private IList<Book> _books = new List<Book>()
    {
        new Book
        {
           Id = 1,
           AuthorName = "Roman Kowal",
           ReleaseDate = new DateTime(2022, 10, 1),
           Title = "Big book",
           Price = 25.99m
        },
        new Book
        {
           Id = 2,
           AuthorName = "Roman Kowal",
           ReleaseDate = new DateTime(2023, 10, 1),
           Title = "Big book 2",
           Price = 35.99m
        },
        new Book
        {
           Id = 3,
           AuthorName = "Roman Kowal",
           ReleaseDate = new DateTime(2018, 05, 13),
           Title = "Autobiography",
           Price = 44.99m
        },
        new Book {
           Id = 4,
           AuthorName = "Marek Nowak",
           ReleaseDate = new DateTime(2011, 12, 11),
           Title = "C# Pro",
           Price = 145m
        },
        new Book
        {
           Id = 5,
           AuthorName = "Marek Nowak",
           ReleaseDate = new DateTime(2023, 08, 01),
           Title = "C# 10 Pro",
           Price = 299.99m
        }
     };

    // ma zwrócić dto z tymi samymi właściwościami które ma model book
    public Book GetBookById(int id)
    {
        var book = _books.FirstOrDefault(x => x.Id == id);

        return book;
    }

    // ma zwrócić posortowane książki po tytułach alfabetycznie od najmniejszego
    // dto zawiera tylko cenę i tytuł
    public List<Book> GetBookByTitle(string title)
    {
        var books = _books.Where(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase)).ToList();

        return books;
    }

    // ma zwrócić najnowszą książkę autora
    // dto zawiera nazwę autora, datę wydania oraz cenę
    public Book GetNewestBooksByAuthorName(string authorName)
    {
        var book = _books.FirstOrDefault(x => x.AuthorName.Equals(authorName, StringComparison.InvariantCultureIgnoreCase));

        return book;
    }
}
