namespace Inventory_Management_System.Models;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Price} {this.Quantity}";
    }
}