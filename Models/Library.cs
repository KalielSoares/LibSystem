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
        if (!Books.Any(x => x.ISBN == book.ISBN))
        {
            Books.Add(book);    
        }
        else
        {
            Console.WriteLine($"Book with a {book.ISBN} already exists");
        }
    }

    public void RemoveBook(string title)
    {
        Book? bookToRemove = Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Book '{bookToRemove.Title}' removed.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found.");
        }
    }


    public void ListBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title} | Author: {book.Author} | ISBN: {book.ISBN} | Borrow: {book.IsBorrowed}");
        }
    }
    
    public Book? FindBook(string title)
    {
            return Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Book> ListBorrowBooks()
    {

        return Books.Where(p => p.IsBorrowed == true);
    }
    
    
}