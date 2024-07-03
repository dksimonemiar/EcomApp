using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models;

public class Review
{
    [Required]
    public int ProductId { get; set; } 
        
    [Required]
    public int UserId { get; set; } 
        
    public string Content { get; set; } // The text content of the review
    
    public int Rating { get; set; } // The rating given in the review (1 to 5)
}