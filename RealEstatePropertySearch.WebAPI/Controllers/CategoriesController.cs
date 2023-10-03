using Microsoft.AspNetCore.Mvc;
using RealEstatePropertySearch.Business.Abstract;

namespace RealEstatePropertySearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var categoryList = _categoryService.GetAll();
            if (categoryList == null)
            {
                return BadRequest();
            }
            return Ok(categoryList);
        }
    }
}
