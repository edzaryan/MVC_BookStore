using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext? _context = null;

        public BookRepository(BookStoreContext context) => _context = context;

        public async Task<List<BookModel>> GetBooks(string categories, int page)
        {
            var books = new List<BookModel>();

            var allBooks = await _context.Books
                                .Where(b => b.Category.Name == categories)
                                .Skip((page - 1) * 16)
                                .Take(page).ToListAsync();

            if (allBooks?.Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        TotalPage = book.TotalPage,
                        LanguageId = book.LanguageId,
                        Description = book.Description,
                        Category = book.Category.Name,
                        Author = book.Author,
                        Language = book?.Language?.Name,
                        CoverImageUrl = book.CoverImageUrl,
                    });
                }
            }

            return books;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            return await _context.Books.Where(book => book.Id == id)
                    .Select(book => new BookModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        Category = book.Category.Name,
                        Description = book.Description,
                        LanguageId = book.LanguageId,
                        Language = book.Language.Name,
                        TotalPage = book.TotalPage,
                        CoverImageUrl = book.CoverImageUrl,
                        Gallery = book.bookGallery.Select(g => new GalleryModel
                        {
                            Id = g.Id,
                            Name = g.Name,
                            URL = g.URL,
                        }).ToList(),
                        BookPdfFileUrl = book.BookPdfFileUrl
                    }).FirstOrDefaultAsync();
        }

        public async Task<List<BookModel>> GetTopBooks(int count)
        {
            return await _context.Books
                            .Select(book => new BookModel
                            {
                                Id = book.Id,
                                Title = book.Title,
                                Description = book.Description,
                                CoverImageUrl = book.CoverImageUrl,
                                Author = book.Author
                            }).Take(count).ToListAsync();
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Book
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                TotalPage = model.TotalPage,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                LanguageId = model.LanguageId,
                CoverImageUrl = model.CoverImageUrl,
                BookPdfFileUrl = model.BookPdfFileUrl
            };

            newBook.bookGallery = new List<BookGallery>
            {
                new BookGallery
                {
                    Name = model.CoverPhoto.FileName,
                    URL = model.CoverImageUrl
                }
            };

            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }
    }
}
