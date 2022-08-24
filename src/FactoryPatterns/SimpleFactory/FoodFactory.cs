namespace SimpleFactory;

public static class FoodFactory
{
    // Here we broke open closed principle wich is not a good practice.
    public static IFood? GetFood(string title)
    {
        title = title.ToLower().Trim();

        switch (title)
        {
            case "ice cream":
                return new IceCream();
            case "burger":
                return new Burger();
            case "soup":
                return new Soup();
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error in taking order: Unknown title...\n");
                Console.ResetColor();
                return null;
        }
    }
}
