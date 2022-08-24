namespace FactoryMethod;

public class Steak : IFood
{
    public double Price { get; } = 9.75;

    public void Prepare()
    {
        Console.WriteLine("Stake prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The Stake served in a white plate with vegetables.\n");
    }
}
