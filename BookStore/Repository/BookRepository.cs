using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext? _context = null;

        public BookRepository(BookStoreContext context) => _context = context;

        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();

            var allBooks = await _context.Books.ToListAsync();

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
                        Category = book.Category,
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
                        Category = book.Category,
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

            newBook.bookGallery = new List<BookGallery>();

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

        //private List<BookModel> DataSource()
        //{
        //    return new List<BookModel>()
        //    {
        //        new BookModel() { 
        //            Id = 1, 
        //            Title = "MVC", 
        //            Author = "Naira Margaryan", 
        //            Description = "MVC This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 560,
        //        },
        //        new BookModel() { 
        //            Id = 2, 
        //            Title = "C#", 
        //            Author = "David Blane",
        //            Description = "C# This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 1560,
        //        },
        //        new BookModel() { 
        //            Id = 3, 
        //            Title = "Java", 
        //            Author = "Jack Swarrow",
        //            Description = "Java This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 1260,
        //        },
        //        new BookModel() { 
        //            Id = 4, 
        //            Title = "Ruby", 
        //            Author = "Karen Fisher",
        //            Description = "Ruby This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 510,
        //        },
        //        new BookModel() { 
        //            Id = 5, 
        //            Title = "C++", 
        //            Author = "Garik Martirosyan",
        //            Description = "C++ This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 560,
        //        },
        //        new BookModel() { 
        //            Id = 6, 
        //            Title = "C", 
        //            Author = "Karen Stepanyan",
        //            Description = "C This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
        //            Category = "Programming",
        //            Language = "English",
        //            TotalPage = 860,
        //        },
        //    };
        //}
    }
}
