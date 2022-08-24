namespace FactoryMethod;

public interface IFoodFactory
{
    IFood? GetFood(string title);
}
