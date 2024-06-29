using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models;

public class Review
{
    [Required]
    public int ProductId { get; set; } 
        
    [Required]
    public int UserId { get; set; } 
        
    [Required]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Content must be between 10 and 500 characters.")]
    public string Content { get; set; } // The text content of the review
    
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; } // The rating given in the review (1 to 5)
}