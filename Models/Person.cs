namespace LibrarySystem.Models;

public abstract class Person
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Person(string name, string email)
    {
        Name = name; 
        Email = email;
    }

    public string GetDetails()
    {
        return $"Name: {Name}\nEmail: {Email}\n";
    }
}