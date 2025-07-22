using Inventory_Management_System.Utils;

namespace Inventory_Management_System.MainPoint;

internal abstract class MainPoint
{
    private static readonly MainController Controller = new MainController();
    private static bool _showWelcomeMessage = true;

    private static void Main(string[] args)
    {
        while (true)
        {
            ShowInstructions();
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var number))
            {
                if (number == Constants.CloseFlag) break;
                ProcessUserChoice(number);
            }
            else
            {
                UserMessages.ShowOptionErrorMessage();
            }
        }
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
            UserMessages.ShowSecondaryWelcomeMessage();
        }
    }

    private static void ProcessUserChoice(int number)
    {
        switch (number)
        {
            case Constants.AddProduct:
                Controller.AddProduct();
                break;
            case Constants.ViewAllProducts:
                Controller.ViewAllProducts();
                break;
            case Constants.EditAProduct:
                Controller.EditProduct();
                break;
            case Constants.DeleteAProduct:
                Controller.DeleteProduct();
                break;
            case Constants.SearchAProduct:
                Controller.SearchAProduct();
                break;
            default:
                UserMessages.ShowOptionErrorMessage();
                break;
        }
    }
}