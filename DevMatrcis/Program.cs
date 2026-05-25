//create a coffee sale app using switch cas
Console.WriteLine("Welcome to Dev Coffee, what would you like to order");

Top:
Console.WriteLine("select your order by picking the order number ");
Console.WriteLine("1.BlackCoffee == 500.");
Console.WriteLine("2.Tea == 1500.");
Console.WriteLine("3.CreamCoffee == 600");
Console.WriteLine("4.Expresso == 2000");
Console.WriteLine("5.Cappuccino == 3500");
Console.WriteLine("6. Bread == 500");

int choice = int.Parse(Console.ReadLine());

int price = 0;
string coffeeName = "";

switch (choice)
{
    case 1:
        coffeeName = "BlackCoffee";
        price = 500;
        break;
    case 2:
        coffeeName = "Tea";
        price = 1500;
        break;
    case 3:
        coffeeName = "CreamCoffee";
        price = 600;
        break;
    case 4:
        coffeeName = "Expresso";
        price = 2000;
        break;
    case 5:
        coffeeName = "Cappuccino";
        price = 3500;
        break;
    case 6:
        coffeeName = "Bread";
        price = 500;
        break;
    default:
        Console.WriteLine("Please go back to the available options." +
            " Please try again by clicking enter.");
        Console.ReadLine();
        goto Top;
}

Console.Write($"How many {coffeeName} do you want? ");
int qty = int.Parse(Console.ReadLine());

int total = price * qty;

// Output with labels
Console.WriteLine("\n--- Receipt ---");
Console.WriteLine($"Coffee: {coffeeName}");
Console.WriteLine($"Unit Price: ₦ {price}");
Console.WriteLine($"Quantity: {qty}");
Console.WriteLine($"Total: ₦ {total}");
    