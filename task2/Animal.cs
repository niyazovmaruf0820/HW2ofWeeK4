namespace task2;

public abstract class Animal
{
    public string Name { get; set; }
    public abstract void SetName(string name);
    public abstract string GetName();
    public abstract void Eat();
}
