namespace SimpleFactory;

public class Burger : IFood
{
    public int Calories { get; } = 295;

    public void Prepare()
    {
        Console.WriteLine("The burger prepared.");
    }

    public void Serve()
    {
        Console.WriteLine("The burger served in a stone plate with fries.");
    }
}
