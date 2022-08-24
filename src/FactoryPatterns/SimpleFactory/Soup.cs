namespace SimpleFactory;

public class Soup : IFood
{
    public int Calories { get; } = 69;

    public void Prepare()
    {
        Console.WriteLine("Soup prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The Soup served in a white bowl.");
    }
}
