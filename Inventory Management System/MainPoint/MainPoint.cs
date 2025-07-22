using Inventory_Management_System.Models;

class MainPoint
{
    private Store Store { get; set; }
    private static bool showWelcomeMessage = true;

    static void Main(string[] args)
    {
        while (true)
        {
            ShowInstructions();
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out var number))
            {
                HandleUserChoose(number);
            }
            else
            {
                ShowErrorMessage();
            }
        }
    }

    private static void HandleUserChoose(int number)
    {
        switch (number)
        {
            case 1:

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            default:
                ShowErrorMessage();
                break;
        }
    }

    private static void ShowErrorMessage()
    {
        Console.WriteLine("Invalid number. please enter a valid option !!");
    }

    private static void ShowInstructions()
    {
        if (showWelcomeMessage)
        {
            ShowWelcomeMessage();
            showWelcomeMessage = false;
        }
        else
        {
            SecondaryWelcomeMessage();
        }
    }

    private static void ShowWelcomeMessage()
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

    private static void SecondaryWelcomeMessage()
    {
        Console.WriteLine("Welcome Again!");
        Console.WriteLine("Please choose an operation number !");
    }
}