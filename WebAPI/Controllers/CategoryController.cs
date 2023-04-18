using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetProductsByCategoryAsync(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetProductsByCategoryAsync(categoryId));
        }
    }
}
