// UserInterface userInterface = new();
// userInterface.MainMenu();

// (string Title, int Pages) book1 = ("Frankenstein", 350);

// Console.WriteLine($"Title: {book1.Title}, Pages: {book1.Pages}");

// var book1 = new Book("Hamlet", 200);
// var book2 = new Book("Great Gatsby", 300);

internal abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by derived classes
    public abstract void MakeSound();
}