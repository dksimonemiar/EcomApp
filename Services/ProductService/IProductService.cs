using EcomApp.Models;

namespace EcomApp.Services.ProductService;

public interface IProductService
{
    Task<List<Review>> GetProductReviews(int id);
    Task<Review> PostProductReview(int id, ReviewDTO review);
}