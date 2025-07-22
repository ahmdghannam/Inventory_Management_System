namespace Inventory_Management_System.Models;

public class Store
{
    private List<Product> Products;

    public Store()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        this.Products.Add(product);
    }
    
}