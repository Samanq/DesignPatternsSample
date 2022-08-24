// This a a client of the factory.
using SimpleFactory;

var totalPrice = 0.0;

var soup = FoodFactory.GetFood("soup");
if (soup != null)
{
    soup.Prepare();
    soup.Serve();

    totalPrice += soup.Price;
}

var burger = FoodFactory.GetFood("burger");
if (burger != null)
{
    burger.Prepare();
    burger.Serve();

    totalPrice += burger.Price;
}

var iceCream = FoodFactory.GetFood("ice cream");
if (iceCream != null)
{
    iceCream.Prepare();
    iceCream.Serve();

    totalPrice += iceCream.Price;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"The total price is: ${totalPrice}");
Console.ResetColor();