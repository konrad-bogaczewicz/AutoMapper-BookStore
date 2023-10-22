﻿namespace AutoMapper.BookStore.Models;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public string AuthorName { get; set; }

    public DateTime ReleaseDate { get; set; }
}
