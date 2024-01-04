namespace task2;

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine($"The {Name} is eating");
    }

    public override string GetName()
    {
        return Name;
    }

    public override void SetName(string name)
    {
        Name = name;
    }
}
