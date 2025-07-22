namespace Inventory_Management_System.Utils;

public class UserMessages
{
    public static void ShowGeneralErrorMessage()
    {
        Console.WriteLine("Invalid Input please try again !!");
    }

    public static void ShowOptionErrorMessage()
    {
        Console.WriteLine("Invalid number. please enter a valid option !!");
    }

    public static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Store!");
        Console.WriteLine("Here you can manage and the private store you own!");
        Console.WriteLine("For help or any information contact me at info@Gh.com");
        Console.WriteLine("Please choose one of the following options: ");
        Console.WriteLine("1.Add a product: please write the product name, price, and quantity");
        Console.WriteLine("2.View all products");
        Console.WriteLine("3.Edit a product: please provide the name of the product");
        Console.WriteLine("4.Delete a product: please provide the name of the product");
        Console.WriteLine("5.Search for a product: please provide the name of the product");

        Console.WriteLine("6.Exit");
    }

    public static void ShowSecondaryWelcomeMessage()
    {
        Console.WriteLine("Welcome Again!");
        Console.WriteLine("Please choose an operation number !");
    }

    public static void ShowProductNameNotFoundMessage()
    {
        Console.WriteLine("Product with this name not found!");
    }
}