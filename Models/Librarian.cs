namespace LibrarySystem.Models;

public class Librarian : Person
{
    public Guid EmpolyeeId { get; set; }

    public Librarian(string name,string email) : base(name, email)
    {
        EmpolyeeId = Guid.NewGuid();
    }

    public void AddBook(Library library,Book book)
    {
        library.AddBook(book);
        Console.WriteLine($"{Name} has added {book.Title} to Library");
    }

    public void RemoveBook(Library library, Book book)
    {
        library.RemoveBook(book);
        Console.WriteLine($"{Name} has removed {book.Title} from Library");
    }
    
}