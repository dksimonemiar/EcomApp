using Microsoft.EntityFrameworkCore;
using EcomApp.Data;
using EcomApp.Exceptions;
using EcomApp.Models;

namespace EcomApp.Services.ProductService;

public class ProductService : IProductService
{
    private readonly ProductContext _context;

    public ProductService(ProductContext context)
    {
        _context = context;
    }
    public async Task<List<Review>> GetProductReviews(int productId)
    {
        return await _context.Reviews.Where(r=> r.ProductId == productId).ToListAsync();
    }
    
    public async Task<Review> CreateProductReview(int productId, ReviewDTO review)
    {
        // Check if the user has already reviewed the product - secure async call
        var existingReview = await _context.Reviews.FirstOrDefaultAsync(r => r.ProductId == productId && r.UserId == review.UserId);
        if (existingReview != null)
        {
            throw new HttpStatusCodeException(400, "User has already reviewed this product.");
        }
        var newReview = new Review
        {
            ProductId = productId,
            UserId = review.UserId,
            Rating = review.Rating,
            Content = review.Content
        };
        var createdReview =_context.Reviews.Add(newReview);
        await _context.SaveChangesAsync();
        return createdReview.Entity;
    }
}