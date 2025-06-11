namespace LibrarySystem.Models;

public class Library
{
    public string Name { get; set; }
    public IList<Book> Books { get; set; }


    public Library(string name)
    {
        Name=name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void ListBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"book: {book.Title}");
        }
    }
    
}