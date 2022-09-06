namespace NetGraphQL.Domain.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Description { get; set; }
}