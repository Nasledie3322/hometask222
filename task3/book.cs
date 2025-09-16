
using System;

namespace Task3;

public class Book
{
    public Book(string title, string genre, int pages)
    {
        this.title = title;
        this.genre = genre;
        this.pages = pages;
    }
    string title;
    string genre;
    int pages;
    public string GetInfo()
    {
        return $"Книга: {title}, Жанр: {genre}, Страниц: {pages}";
    }
}