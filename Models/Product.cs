namespace HomeWorkDapper.Models;

public class Product
{
    public Product(){}
    public Product((string, string, int, double) product)
    {
        Name = product.Item1;
        Description = product.Item2;
        StockQuantity = product.Item3;
        Price = (decimal)product.Item4;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
}