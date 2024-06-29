namespace EcomApp.Models;

public class Review
{
    public int Id { get; set; } 
    public string ProductId { get; set; } 
    public string UserId { get; set; } 
    public string Content { get; set; } 
    public int Rating { get; set; } // The rating given in the review (1 to 5)
}