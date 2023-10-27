namespace HomeWorkDapper.Models;

public class Order
{
    public Order(){}
    public Order((int, int, int) order)
    {
        CustomerId = order.Item1;
        ProductId = order.Item2;
        Quantity = order.Item3;
    }

    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}