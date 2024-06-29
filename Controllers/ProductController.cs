using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcomApp.Models;
using EcomApp.Services.ProductService;

namespace EcomApp.Controllers;

[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
    // GET: api/review
    [HttpGet("{id}/reviews")]
    public async Task<ActionResult<IEnumerable<Review>>> GetReviews(int id)
    {
        try 
        {
            return Ok(id);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    
}