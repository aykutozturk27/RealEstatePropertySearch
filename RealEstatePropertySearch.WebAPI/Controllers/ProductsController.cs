using Microsoft.AspNetCore.Mvc;
using RealEstatePropertySearch.Business.Abstract;

namespace RealEstatePropertySearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var productList = _productService.GetAll();
            if (productList == null)
            {
                return BadRequest();
            }
            return Ok(productList);
        }

        [HttpGet("GetByTitle")]
        public IActionResult GetByTitle(string title)
        {
            var product = _productService.GetByTitle(title);
            if (product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }
    }
}
