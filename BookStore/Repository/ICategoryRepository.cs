using BookStore.Models;

namespace BookStore.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetCategoriesAsync();
    }
}
