using ContosoCrafts.Models;
using ContosoCrafts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private JsonFileProductService _productService { get; }
        public ProductsController(JsonFileProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts()!;
        }

        [Route("rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string productId,
            [FromQuery] int rating
        )
        {
            _productService.AddRating(productId, rating);
            return Ok();
        }
    }
}
