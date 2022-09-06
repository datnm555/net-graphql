namespace NetGraphQL.Domain.Entities;

public class Order
{
    public Order()
    {
        OrderDetails = new HashSet<OrderDetail>();
    }

    public int Id { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

}