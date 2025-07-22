using Inventory_Management_System.Models;
using Inventory_Management_System.Utils;

class MainPoint
{
    private static Store _store = new Store();
    private static bool _showWelcomeMessage = true;

    // constants
    private const int CLOSE_FLAG = 6;

    static void Main(string[] args)
    {
        while (true)
        {
            ShowInstructions();
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var number))
            {
                if (number == CLOSE_FLAG) break;
                HandleUserChoose(number);
            }
            else
            {
                UserMessages.ShowOptionErrorMessage();
            }
        }
    }

    private static void HandleUserChoose(int number)
    {
        switch (number)
        {
            case 1:
                AddProduct();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                UserMessages.ShowOptionErrorMessage();
                break;
        }
    }

    private static void AddProduct()
    {
        Console.WriteLine("Please enter the product name, price, quantity separated by commas and inorder");
        var input = Console.ReadLine();

        var values = input.Split(',');
        if (values.Length < 3 || string.IsNullOrEmpty(input))
        {
            UserMessages.ShowGeneralErrorMessage();
            return;
        }

        var name = values[0];

        if (!double.TryParse(values[1], out var price)
            || !int.TryParse(values[2], out var quantity))
        {
            UserMessages.ShowGeneralErrorMessage();
            return;
        }

        var product = new Product(name, price, quantity);
        Console.WriteLine("the product has been added");
        _store.AddProduct(product);
    }

    private static void ShowInstructions()
    {
        if (_showWelcomeMessage)
        {
            UserMessages.ShowWelcomeMessage();
            _showWelcomeMessage = false;
        }
        else
        {
            UserMessages.SecondaryWelcomeMessage();
        }
    }
}