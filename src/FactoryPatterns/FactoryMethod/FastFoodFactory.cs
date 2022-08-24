namespace FactoryMethod;

public class FastFoodFactory : IFoodFactory
{
    // Here we broke open closed principle wich is not a good practice.
    // Because everytime that we need to create a new type of food we have to modify the FoodFactory class and add another case for the new type.
    public IFood? GetFood(string title)
    {
        title = title.ToLower().Trim();

        switch (title)
        {
            case "ice cream":
                return new IceCream();
            case "burger":
                return new Burger();
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error in taking order: Unknown title...\n");
                Console.ResetColor();
                return null;
        }
    }
}
