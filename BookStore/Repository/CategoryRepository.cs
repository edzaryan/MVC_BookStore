using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreContext _context;

        public CategoryRepository(BookStoreContext content) => _context = content;

        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            return await _context.Categories
                                    .Select(category => new CategoryModel
                                    {
                                        Id = category.Id,
                                        Name = category.Name,
                                    })
                                    .ToListAsync();
        }
    }
}
