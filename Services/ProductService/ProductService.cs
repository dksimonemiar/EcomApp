using Microsoft.EntityFrameworkCore;
using EcomApp.Data;
using EcomApp.Models;

namespace EcomApp.Services.ProductService;

public class ProductService : IProductService
{
    private readonly ProductContext _context;

    public ProductService(ProductContext context)
    {
        _context = context;
    }
    public async Task<List<Review>> GetProductReviews(int id)
    {
        return await _context.Reviews.Where(r=> r.ProductId == id).ToListAsync();
    }
    
    public async Task<Review> PostProductReview(int id, Review review)
    {
        var currentUserId = 1;
        var newReview = new Review
        {
            ProductId = id,
            UserId = currentUserId,
            Rating = review.Rating,
            Content = review.Content
        };
        var createdReview =_context.Reviews.Add(newReview);
        await _context.SaveChangesAsync();
        return createdReview.Entity;
    }
}