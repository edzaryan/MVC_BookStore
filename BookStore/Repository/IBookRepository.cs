using BookStore.Enums;
using BookStore.Models;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);

        Task<List<BookModel>> GetBooks(string categories, string letter, int page);

        Task<BookModel> GetBookById(int id);

        Task<List<BookModel>> GetBookList(BookType type, int count);

        Task<List<BookModel>> SearchBook(string v, int page);
    }
}