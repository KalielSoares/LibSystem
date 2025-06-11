using System.Diagnostics;
using LibrarySystem.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Welcome to the '  ' Library!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("How is the name of library?");
        string libName = Console.ReadLine();

        var library = new Library(libName);
        
        Console.Clear();
        
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Welcome to the {library.Name} Library!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 - Register a new Employee");
        Console.WriteLine("2 - Register a new Book");
        Console.WriteLine("3 - Register a new Member");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("----------------------------------");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("");
                var librarian = new Librarian();
                break;
        }
        
    }
}

