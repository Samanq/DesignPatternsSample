namespace SimpleFactory;

public class IceCream : IFood
{
    public int Calories { get; } = 207;

    public void Prepare()
    {
        Console.WriteLine("Ice cream prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The Ice cream serverd in a cone.");
    }
}
