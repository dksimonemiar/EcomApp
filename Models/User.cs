namespace EcomApp.Models;

public class User
{
    public string Id { get; set; } 
    public string Username { get; set; }
    public ICollection<Review> Reviews { get; set; }
}