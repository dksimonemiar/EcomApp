using EcomApp.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcomApp.Models;
using EcomApp.Services.ProductService;

namespace EcomApp.Controllers;

[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    // GET: api/products/{productId}/reviews
    [HttpGet("{productId}/reviews")]
    public async Task<ActionResult<IEnumerable<Review>>> GetReviews(int productId)
    {
        try 
        {
            var reviews = await _productService.GetProductReviews(productId);
            return Ok(reviews);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    // POST: api/products/{productId}/reviews
    [HttpPost("{productId}/reviews")]
    public async Task<ActionResult<Review>> PostReview(int productId, [FromBody]ReviewDTO review)
    {
        try 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newReview = await _productService.CreateProductReview(productId, review);
            return Ok(newReview);
        }
        catch (HttpStatusCodeException ex)
        {
            return StatusCode(ex.StatusCode, new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    
}