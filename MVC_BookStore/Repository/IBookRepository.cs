using MVC_BookStore.Models;

namespace MVC_BookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddBookAsync(BookModel model);
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBookAsync(string title, string authorName);
    }
}