using BookStore.Models;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetBooks(string categories, int page);
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooks(int count);
        List<BookModel> SearchBook(string title, string authorName);
    }
}