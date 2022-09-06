namespace NetGraphQL.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public List<int> ProductId { get; set; }
    
}