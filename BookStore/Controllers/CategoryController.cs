using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository? _categoryRepository = null;

        public CategoryController(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;


        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            var data = await _categoryRepository.GetCategoriesAsync();

            return Ok(data);
        }
    }
}
