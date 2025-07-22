using Inventory_Management_System.Models;
using Inventory_Management_System.Utils;

namespace Inventory_Management_System.MainPoint;

public class MainController
{
    private static readonly Store _store = new Store();

    public void AddProduct()
    {
        var product = ParseProductFromUserInput();
        if (product == null) return;
        _store.AddProduct(product);
        Console.WriteLine("the product has been added");
    }

    public void ViewAllProducts()
    {
        var products = _store.GetAllProducts();
        for (var i = 0; i < products.Count; i++)
        {
            var product = products[i];
            Console.WriteLine($"{i + 1} -> {product}");
        }
    }

    public void EditProduct()
    {
        var productName = GetProductName();
        if (productName == null) return;

        if (!_store.HasProductWithName(productName))
        {
            UserMessages.ShowProductNameNotFoundMessage();
            return;
        }
        var product = ParseProductFromUserInput();
        if (product == null) return;
        
        _store.EditProduct(productName, product);
    }
    
    public void DeleteProduct()
    {
        var productName = GetProductName();
        if (productName == null) return;
        
        _store.RemoveProduct(productName);
    }

    public void SearchAProduct()
    {
        var productName = GetProductName();
        if (productName == null) return;
        
        _store.SearchForProduct(productName);
    }
    
    
    
    // private utils 
    private Product? ParseProductFromUserInput()
    {
        Console.WriteLine("Please enter the product name, price, quantity separated by commas and inorder");
        var input = Console.ReadLine();

        var values = input.Split(',');
        if (values.Length < 3 || string.IsNullOrEmpty(input))
        {
            UserMessages.ShowGeneralErrorMessage();
            return null;
        }

        var name = values[0];

        if (!double.TryParse(values[1], out var price)
            || !int.TryParse(values[2], out var quantity))
        {
            UserMessages.ShowGeneralErrorMessage();
            return null;
        }

        return new Product(name, price, quantity);
    }
    private string? GetProductName()
    {
        Console.WriteLine("Please enter the product name");
        var input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input)) return input.Trim();
        UserMessages.ShowGeneralErrorMessage();
        return null;
    }
}