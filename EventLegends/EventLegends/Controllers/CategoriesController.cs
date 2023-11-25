using EventLegends.Models.DTOs;
using EventLegends.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
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

            [HttpGet]
            public async Task<IActionResult> GetAllCategories()
            {
                var categories = await _categoryService.GetAllCategories();
                return Ok(categories);
            }

            [HttpGet("{categoryId}")]
            public async Task<IActionResult> GetCategoryById([FromRoute] Guid categoryId)
            {
                var category = await _categoryService.GetCategoryById(categoryId);

                if (category == null)
                {
                    return NotFound();
                }

                return Ok(category);
            }

            [HttpPost]
            public async Task<IActionResult> CreateCategory([FromBody]CategoryDto categoryDto)
            {
                await _categoryService.CreateCategory(categoryDto);
                return Ok();
            }

            [HttpPut("{categoryId}")]
            public async Task<IActionResult> UpdateCategory([FromRoute]Guid categoryId,[FromBody] CategoryDto categoryDto)
            {
                await _categoryService.UpdateCategory(categoryId, categoryDto);
                return Ok();
            }

            [HttpDelete("{categoryId}")]
            public async Task<IActionResult> DeleteCategory([FromRoute] Guid categoryId)
            {
                await _categoryService.DeleteCategory(categoryId);
                return Ok();
            }
        }
    
}
