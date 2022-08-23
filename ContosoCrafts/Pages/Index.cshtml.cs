using ContosoCrafts.Models;
using ContosoCrafts.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private JsonFileProductService _productService;
        public IEnumerable<Product>? Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}