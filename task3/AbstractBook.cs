namespace task3;

public abstract class AbstractBook : IReadable
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void Read()
    {
        System.Console.WriteLine("Someone is reading this book");
    }

}
