using Inventory_Management_System.Utils;

namespace Inventory_Management_System.Models;

public class Store
{
    private List<Product> Products;

    public Store()
    {
        Products = new List<Product>();
    }

    public List<Product> getAllProducts() => Products;

    public bool hasProductWithName(string name) => Products.Exists(product => product.Name == name);

    public bool EditProduct(string oldName, Product product)
    {
        foreach (var p in Products)
        {
            if (p.Name != oldName) continue;
            p.Name = product.Name;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            return true;
        }

        return false;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(string productName)
    {
        var productToRemove = Products.Find(p => p.Name == productName);
        if (productToRemove != null)
        {
            Products.Remove(productToRemove);
        }
    }

    public void SearchForProduct(string productName)
    {
        foreach (var p in Products)
        {
            if (p.Name != productName) continue;
            Console.WriteLine(p);
        }
    }
}