using EcomApp.Models;

namespace EcomApp.Services.ProductService;

public interface IProductService
{
    Task<List<Review>> GetProductReviews(int productId);
    Task<Review> PostProductReview(int productId, ReviewDTO review);
}