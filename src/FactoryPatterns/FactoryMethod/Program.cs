using FactoryMethod;

var totalPrice = 0.0;

IFoodFactory fastFood = new FastFoodFactory();
IFoodFactory restaurant = new InternationalFoodFactory();

// Soup
var soup = restaurant.GetFood("Soup");
if (soup != null)
{
    soup.Prepare();
    soup.Serve();

    totalPrice += soup.Price;
}

// Burger
var burger = fastFood.GetFood("burger");
if (burger != null)
{
    burger.Prepare();
    burger.Serve();

    totalPrice += burger.Price;
}

// Steak
var steak = restaurant.GetFood("steak");
if (steak != null)
{
    steak.Prepare();
    steak.Serve();

    totalPrice += steak.Price;
}

// Ice Cream
var iceCream = fastFood.GetFood("ice cream");
if (iceCream != null)
{
    iceCream.Prepare();
    iceCream.Serve();

    totalPrice += iceCream.Price;
}

// Total price
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"The total price is: ${totalPrice}");
Console.ResetColor();
