namespace task1;

public class Car : IVehicle
{
    private int Fuel;

    public Car(int fuel)
    {
        Fuel = fuel;
    }

    public void Drive()
    {
        if (Fuel > 0)
        {
            Console.WriteLine("Driving");
        }
        else
        {
            Console.WriteLine("Out of fuel");
        }
    }

    public bool Rafuel(int amount)
    {
        Fuel += amount;
        return true;
    }
}