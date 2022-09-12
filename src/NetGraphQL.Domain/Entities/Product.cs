namespace NetGraphQL.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public virtual OrderDetail OrderDetail { get; set; }
}