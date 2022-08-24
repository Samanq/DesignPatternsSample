namespace SimpleFactory;

public class Soup : IFood
{
    public double Price { get; } = 4.55;

    public void Prepare()
    {
        Console.WriteLine("Soup prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The Soup served in a white bowl.\n");
    }
}
