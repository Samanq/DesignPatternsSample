namespace FactoryMethod;

public class IceCream : IFood
{
    public double Price { get; } = 3.25;

    public void Prepare()
    {
        Console.WriteLine("Ice cream prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The Ice cream serverd in a cone.\n");
    }
}
