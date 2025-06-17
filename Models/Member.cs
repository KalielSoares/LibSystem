namespace LibrarySystem.Models;

public class Member : Person
{
    public Guid memberId { get; set; }
    public IList<Book> BorrowedBooks { get; set; }

    public Member(string name,string email) : base(name,email)
    {
        memberId = Guid.NewGuid();
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        if (book.IsBorrowed)
        {
            Console.WriteLine("this book is already borrowed");
        }
        else
        {
            book.Borrow();
            BorrowedBooks.Add(book);
        }
    }
    
    
    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        { 
            book.ReturnBook();
            BorrowedBooks.Remove(book);
        }
    }

    public void listBorrowedBooks()
    {
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine($"{book}");
        }
    }
    
  

    
}