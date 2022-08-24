// This a a client of the factory.
using SimpleFactory;


var soup = FoodFactory.GetFood("soup");
if (soup != null)
{
    soup.Prepare();
    soup.Serve();
}

var burger = FoodFactory.GetFood("burger");
if (burger != null)
{
    burger.Prepare();
    burger.Serve();
}

var iceCream = FoodFactory.GetFood("ice cream");
if (iceCream != null)
{
    iceCream.Prepare();
    iceCream.Serve();
}

Console.WriteLine($"Soup calories: {soup.Calories}");
Console.WriteLine($"Burger calories: {burger.Calories}");
Console.WriteLine($"Ice cream calories: {iceCream.Calories}");
Console.WriteLine($"The whole calories is: {soup.Calories + burger.Calories + iceCream.Calories}");