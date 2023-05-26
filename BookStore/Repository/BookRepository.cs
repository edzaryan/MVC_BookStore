using BookStore.Data;
using BookStore.Enums;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext? _context = null;

        public BookRepository(BookStoreContext context) => _context = context;

        public async Task<List<BookModel>> GetBooks(string categories, string letter, int page)
        {
            var books = new List<BookModel>();

            var result = await _context.Books
                                .Where(b => (b.Category.Name == categories) && (b.Title.StartsWith(letter)))
                                .Skip((page - 1) * 16)
                                .Take(16)
                                .ToListAsync();

            if (result != null)
            {
                foreach (var book in result)
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


        public async Task<List<BookModel>> GetBookList(BookType type, int count)
        {
            List<BookModel> books = type switch
            {
                BookType.BestBooksByMonth => await GetBestBooksByMonthAsync(count),
                BookType.BestKids => await GetBestKidsBooksAsync(count),
                BookType.BestYoungAdult => await GetBestYoungAdultBooksAsync(count),
                BookType.NewComingSoon => await GetNewComingSoonBooksAsync(count),
                BookType.TrendingNow => await GetTrendingBooksAsync(count)
            };

            return books;
        }

        private async Task<List<BookModel>> GetBestBooksByMonthAsync(int count)
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

        private async Task<List<BookModel>> GetBestKidsBooksAsync(int count)
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

        private async Task<List<BookModel>> GetBestYoungAdultBooksAsync(int count)
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

        private async Task<List<BookModel>> GetNewComingSoonBooksAsync(int count)
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

        private async Task<List<BookModel>> GetTrendingBooksAsync(int count)
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

        public async Task<List<BookModel>> SearchBook(string v, int page)
        {
            return await _context.Books
                            .Where(b => b.Title.Contains(v))
                            .Select(book => new BookModel
                            {
                                Id = book.Id,
                                Title = book.Title,
                                Description = book.Description,
                                CoverImageUrl = book.CoverImageUrl,
                                Author = book.Author,
                            })
                            .Skip((page - 1) * 16)
                            .Take(16)
                            .ToListAsync();
        }
    }
}
