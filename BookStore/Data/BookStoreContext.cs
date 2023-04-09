using BookStore.Models;
using BookStore.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IBookStoreDataSeedService _jsonFileService;

        public BookStoreContext(DbContextOptions<BookStoreContext> options, 
            IBookStoreDataSeedService jsonFileService)
            : base(options)
        {
            _jsonFileService = jsonFileService;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookGallery> BookGalleries { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedIdentityRoles(builder);
            SeedIdentityUsers(builder);
            SeedLanguages(builder);
            SeedCategories(builder);
            SeedBooks(builder);
            SeedBookGalleries(builder);

            base.OnModelCreating(builder);
        }

        private void SeedIdentityUsers(ModelBuilder builder)
        {
            var user = new ApplicationUser()
            {
                Id = "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                FirstName = "Edgar",
                LastName = "Yeghiazaryan",
                UserName = "edzaryan@gmail.com",
                NormalizedUserName = "EDZARYAN@GMAIL.COM",
                Email = "edzaryan@gmail.com",
                NormalizedEmail = "EDZARYAN@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
            };

            var ph = new PasswordHasher<ApplicationUser>();

            user.PasswordHash = ph.HashPassword(user, "1234");

            builder.Entity<ApplicationUser>().HasData(user);
        }

        private void SeedIdentityRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new
                {
                    Id = "bc6f72c0-66aa-4ec9-adb3-fba947bd0014",
                    Name = "Admin",
                    ConcurrencyStamp = "1",
                    NormalizedName = "ADMIN"
                },
                new
                {
                    Id = "ff6f72c0-66aa-4ec9-adb3-fba947bd0014",
                    Name = "User",
                    ConcurrencyStamp = "2",
                    NormalizedName = "USER"
                }
            );
        }

        private void SeedLanguages(ModelBuilder builder)
        {
            var languages = _jsonFileService.GetLanguages();

            List<Language> languageList = new();

            for (int i = 0; i < languages.Length; i++)
            {
                languageList.Add(new()
                {
                    Id = i + 1,
                    Name = languages[i]
                });
            }

            builder.Entity<Language>().HasData(languageList);
        }

        private void SeedCategories(ModelBuilder builder)
        {
            var categories = _jsonFileService.GetCategories();

            List<Category> categoryList = new();

            for (int i = 0; i < categories.Length; i++)
            {
                categoryList.Add(new()
                {
                    Id = i + 1,
                    Name = categories[i]
                });
            }

            builder.Entity<Category>().HasData(categoryList);
        }

        private void SeedBooks(ModelBuilder builder)
        {
            var bookTitles = _jsonFileService.GetBookTitles();
            var names = _jsonFileService.GetNames();
            var surnames = _jsonFileService.GetSurnames();
            var languages = _jsonFileService.GetLanguages();
            var categories = _jsonFileService.GetCategories();
            var coverImageNames = _jsonFileService.GetCoverImageNames();

            List<Book> bookList = new();

            Random random = new();

            for (int i = 0; i < bookTitles.Length; i++)
            {
                bookList.Add(new()
                {
                    Id = i + 1,
                    Title = bookTitles[i],
                    Author = names[random.Next(0, names.Length)] + " " + surnames[random.Next(0, surnames.Length)],
                    Description = $"{bookTitles[i]} is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!",
                    TotalPage = random.Next(100, 800),
                    LanguageId = random.Next(1, languages.Length),
                    CategoryId = random.Next(1, categories.Length),
                    CoverImageUrl = $"\\files\\books\\coverImages\\{coverImageNames[i]}",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf"
                });
            }

            builder.Entity<Book>().HasData(bookList);
        }

        private void SeedBookGalleries(ModelBuilder builder)
        {
            var bookCoverImageNames = _jsonFileService.GetCoverImageNames();
            var bookGalleryImageNames = _jsonFileService.GetGalleryImageNames();

            List<BookGallery> bookGalleryList = new();

            int TargetId = 1;

            for (int i = 1; i <= bookCoverImageNames.Length; i++)
            {
                bookGalleryList.Add(new()
                {
                    Id = TargetId,
                    BookId = i,
                    Name = "X.jpeg",
                    URL = $"\\files\\books\\coverImages\\{bookCoverImageNames[i - 1]}"
                });

                TargetId++;

                for (int j = 0; j < bookGalleryImageNames.Length; j++)
                {
                    bookGalleryList.Add(new()
                    {
                        Id = TargetId,
                        BookId = i,
                        Name = "X.jpeg",
                        URL = $"\\files\\books\\galleryImages\\{bookGalleryImageNames[j]}"
                    });

                    TargetId++;
                }
            }

            builder.Entity<BookGallery>().HasData(bookGalleryList);
        }

    }
}
