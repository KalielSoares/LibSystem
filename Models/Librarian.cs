namespace LibrarySystem.Models;

public class Librarian : Person
{
    public Guid EmpolyeeId { get; set; }


    public Librarian(string name,string email) : base(name, email)
    {
        EmpolyeeId = Guid.NewGuid();
     
    }

    public void AddBookToLibrary(Library library,Book book)
    {
        library.AddBook(book);
        Console.WriteLine($"{Name} has added {book.Title} to Library");
    }

    public void RemoveBook(Library library, string title)
    {
        library.RemoveBook(title);
        Console.WriteLine($"{Name} has removed {title} from Library");
    }

    public void AddBookToMember(string name,Book book,Library library)
    {
        Member? memberWhoBorrow = library.Members.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (memberWhoBorrow != null)
        {
            memberWhoBorrow.BorrowBook(book);
            
            Console.WriteLine($"{memberWhoBorrow.Name} has borrow {book.Title}");
        }
        else
        {
           Console.WriteLine($"{memberWhoBorrow.Name} has not borrowed {book.Title}");
        }
    }
    
    
}