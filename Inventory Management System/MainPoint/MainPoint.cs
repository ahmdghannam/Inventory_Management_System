using Inventory_Management_System.MainPoint;
using Inventory_Management_System.Models;
using Inventory_Management_System.Utils;

class MainPoint
{
   private static MainController _controller = new MainController();
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
                _controller.AddProduct();
                break;
            case 2:
                _controller.viewAllProducts();
                break;
            case 3:
                _controller.EditProduct();
                break;
            case 4:
                _controller.deleteProduct();
                break;
            case 5:
                _controller.searchAProduct();
                break;
            default:
                UserMessages.ShowOptionErrorMessage();
                break;
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
}