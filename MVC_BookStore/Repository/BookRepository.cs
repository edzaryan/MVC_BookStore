using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_BookStore.Data;
using MVC_BookStore.Models;

namespace MVC_BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _ctx;

        public BookRepository(AppDbContext context) => _ctx = context;

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var books = new List<BookModel>();

            var allbooks = await _ctx.Books.ToListAsync();

            if (allbooks?.Any() == true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        Category = book.Category,
                        Description = book.Description,
                        LanguageId = book.LanguageId,
                        TotalPages = book.TotalPages,
                        CoverImageUrl = book.CoverImageUrl,
                    });
                }
            }

            return books;
        }

        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {
            return await _ctx.Books
                            .Select(b => new BookModel
                            {
                                Title = b.Title,
                                Author = b.Author,
                                Category = b.Category,
                                Description = b.Description,
                                TotalPages = b.TotalPages,
                                CoverImageUrl = b.CoverImageUrl,
                                Language = b.Language.Name,
                                LanguageId = b.LanguageId,
                                BookPdfUrl = b.BookPdfUrl,
                            }).Take(count).ToListAsync();
        }

        public async Task<BookModel> GetBookByIdAsync(int id)
        {
            return await _ctx.Books
                            .Where(b => b.Id == id)
                            .Select(b => new BookModel
                            {
                                Title = b.Title,
                                Author = b.Author,
                                Category = b.Category,
                                Description = b.Description,
                                TotalPages = b.TotalPages,
                                CoverImageUrl = b.CoverImageUrl,
                                Language = b.Language.Name,
                                LanguageId = b.LanguageId,
                                BookPdfUrl = b.BookPdfUrl,
                                Gallery = b.BookGallery.Select(g => new GalleryModel
                                {
                                    Id = g.Id,
                                    Name = g.Name,
                                    URL = g.URL
                                }).ToList()
                            }).FirstOrDefaultAsync();
        }

        public List<BookModel> SearchBookAsync(string title, string authorName)
        {
            return null;
        }

        public async Task<int> AddBookAsync(BookModel model)
        {
            var newBook = new Book()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                LanguageId = model.LanguageId,
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                CreateOn = DateTime.UtcNow,
                UpdateOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                BookPdfUrl = model.BookPdfUrl
            };

            newBook.BookGallery = new List<BookGallery>();

            foreach (var file in model.Gallery)
            {
                newBook.BookGallery.Add(new BookGallery
                {
                    Name = file.Name,
                    URL = file.URL,
                });
            }

            await _ctx.Books.AddAsync(newBook);
            await _ctx.SaveChangesAsync();

            return newBook.Id;
        }
    }
}
