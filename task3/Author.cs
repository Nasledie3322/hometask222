
using System;

namespace Task3;

public class Author
{
    private List<Book> booksList = new List<Book>();
    public Author(string name, int age, string nationality, int books)
    {
        this.name = name;
        this.age = age;
        this.nationality = nationality;
        this.books = books;
    }
    string name;
    int age;
    string nationality;
    int books;
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetNationality()
    {
        return nationality;
    }
    public string Introduce()
    {
        return $"Меня зовут {name}. Мне {age} лет. Я из {nationality}";
    }
    public int CelebrateBirthday()
    {
        return age + 1;
    }
    public void AddBook(Book book)
    {
        booksList.Add(book);
    }
    public void ListBooks()
    {
        foreach (var item in booksList)
        {
            System.Console.WriteLine(item.GetInfo());
        }
    }
}