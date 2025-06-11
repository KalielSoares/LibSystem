using System.Diagnostics;
using LibrarySystem.Models;

class Program
{
    static void Main(string[] args)
    {

        Library library = new Library("Texas Library");

        Librarian librarian = new Librarian("Kaliel", "Kalielsoares6@gmail.com");

        Book book1 = new Book("Clean Code", "Robert C. Martin", "00001");
        Book book2 = new Book("The Pragmatic Programmer", "Andrew Hunt", "00002");
        
        librarian.AddBookToLibrary(library, book1);
        librarian.AddBookToLibrary(library, book2);
        
        library.ListBooks();


        Member member = new Member("Nathan", "nathanzinho@hotmail.com");
    }
}

