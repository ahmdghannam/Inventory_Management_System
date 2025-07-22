using Inventory_Management_System.Models;
using Inventory_Management_System.Utils;

namespace Inventory_Management_System.MainPoint;

public class MainController
{
    private static Store _store = new Store();

    public void AddProduct()
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

    public void viewAllProducts()
    {
        var products = _store.getAllProducts();
        for (int i = 0; i < products.Count; i++)
        {
            var product = products[i];
            Console.WriteLine($"{i + 1} -> {product}");
        }
    }
}