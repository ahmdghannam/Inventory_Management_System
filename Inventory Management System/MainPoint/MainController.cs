using Inventory_Management_System.Models;
using Inventory_Management_System.Utils;

namespace Inventory_Management_System.MainPoint;

public class MainController
{
    private static Store _store = new Store();

    public void AddProduct()
    {
        var product = parseProductFromUserInput();
        if (product == null) return;
        _store.AddProduct(product);
        Console.WriteLine("the product has been added");
    }

    public void viewAllProducts()
    {
        var products = _store.getAllProducts();
        for (var i = 0; i < products.Count; i++)
        {
            var product = products[i];
            Console.WriteLine($"{i + 1} -> {product}");
        }
    }

    public void EditProduct()
    {
        var productName = getProductName();
        if (productName == null) return;

        if (!_store.hasProductWithName(productName))
        {
            UserMessages.ShowProductNameNotFoundMessage();
            return;
        }
        var product = parseProductFromUserInput();
        if (product == null) return;
        
        _store.EditProduct(productName, product);
    }



    public void deleteProduct()
    {
        var productName = getProductName();
        if (productName == null) return;
        
        _store.RemoveProduct(productName);
        
       
    }

    public void searchAProduct()
    {
        throw new NotImplementedException();
    }
    
    // private utils 
    private Product? parseProductFromUserInput()
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

    private string? getProductName()
    {
        Console.WriteLine("Please enter the product name");
        var input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input)) return input;
        UserMessages.ShowGeneralErrorMessage();
        return null;
    }
}