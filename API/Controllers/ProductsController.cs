// Import necessary namespaces
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Define the namespace and class for the ProductsController, which is a controller for managing products
namespace API.Controllers
{
    // Declare that this class is an API controller and specify the route for the controller
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // Declare a private readonly field to hold an instance of the StoreContext (presumably a database context)
        private readonly StoreContext _context;

        // Constructor for the ProductsController that accepts an instance of StoreContext through dependency injection
        public ProductsController(StoreContext context)
        {
            // Assign the injected StoreContext to the private field
            _context = context;
        }

        // HTTP GET endpoint to retrieve a list of all products
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            // Retrieve all products from the database context and convert them to a list
            return await _context.Products.ToListAsync();
        }

        // HTTP GET endpoint to retrieve a specific product by its ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            // Find the product with the specified ID in the database context
            return await _context.Products.FindAsync(id);
        }
    }
}
