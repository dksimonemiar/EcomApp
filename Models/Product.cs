namespace EcomApp.Models;

public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public ICollection<Review> Reviews { get; set; }
}