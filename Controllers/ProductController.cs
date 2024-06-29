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
    // GET: api/review
    [HttpGet("{id}/reviews")]
    public async Task<ActionResult<IEnumerable<Review>>> GetReviews(int id)
    {
        try 
        {
            var reviews = await _productService.GetProductReviews(id);
            return Ok(reviews);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    // POST: api/review
    [HttpPost("{id}/reviews")]
    public async Task<ActionResult<Review>> PostReview(int id, [FromBody]ReviewDTO review)
    {
        try 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newReview = await _productService.PostProductReview(id, review);
            return Ok(newReview);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    
}