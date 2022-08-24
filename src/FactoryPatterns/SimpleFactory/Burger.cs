namespace SimpleFactory;

public class Burger : IFood
{
    public double Price { get; } = 7.8;

    public void Prepare()
    {
        Console.WriteLine("The burger prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The burger served in a stone plate with fries.\n");
    }
}
