namespace LibrarySystem.Models;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsBorrowed {get; set;}

    public Book()
    {
        
    }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsBorrowed = false;
    }

    public void Borrow()
    {
        IsBorrowed = true;
    }

    public void ReturnBook()
    {
        IsBorrowed = false;
    }

    public string GetInfo()
    {
        return $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}";
    }
    
    
}