using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_BookStore.Models;

namespace MVC_BookStore.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGallery> BookGallery { get; set; }
        public DbSet<Language> Languages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Name = "Dutch" },
                new Language { Id = 2, Name = "English" },
                new Language { Id = 3, Name = "Germany" }
            );

            modelBuilder.Entity<Book>().HasData( 
                new Book
                {
                    Id = 1,
                    Title = "In Search of Lost Time",
                    Author = "Marcel Proust",
                    TotalPages = 235,
                    Category = "Modern literature",
                    Description = "In Search of Lost Time, first translated into English as Remembrance of Things Past, and sometimes referred to in French as La Recherche, is a novel in seven volumes by French author Marcel Proust. This early 20th-century work is his most prominent, known both for its length and its theme of involuntary memory.",
                    LanguageId = 1,
                    CreateOn= DateTime.Now,
                    UpdateOn= DateTime.Now,
                    CoverImageUrl = "/books/cover/fg325708-23f6-4321-832a-ba21498ef5e2_images.jpg"
                },
                new Book
                {
                    Id = 2,
                    Title = "Ulysses",
                    Author = "James Joyce",
                    TotalPages = 244,
                    Category = "Novel",
                    Description = "Ulysses is a modernist novel by Irish writer James Joyce. Parts of it were first serialized in the American journal The Little Review from March 1918 to December 1920, and the entire work was published in Paris by Sylvia Beach on 2 February 1922, Joyce's 40th birthday.",
                    LanguageId = 2,
                    CreateOn = DateTime.Now,
                    UpdateOn = DateTime.Now,
                    CoverImageUrl = "/books/cover/12325708-23f6-4321-832a-ba21498ef5e2_images.jpg"
                },
                new Book
                {
                    Id = 3,
                    Title = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    TotalPages = 350,
                    Category = "Novel",
                    Description = "Don Quixote is a Spanish epic novel by Miguel de Cervantes. Originally published in two parts, in 1605 and 1615, its full title is The Ingenious Gentleman Don Quixote of La Mancha or, in Spanish, El ingenioso hidalgo don Quixote de la Mancha.",
                    LanguageId = 3,
                    CreateOn = DateTime.Now,
                    UpdateOn = DateTime.Now,
                    CoverImageUrl = "/books/cover/ttt25708-23f6-4321-832a-ba21498ef5e2_images.jpg"
                },
                new Book
                {
                    Id = 4,
                    Title = "One Hundred Years of Solitude",
                    Author = "Gabriel Garcia Marquez",
                    TotalPages = 450,
                    Category = "Novel",
                    Description = "One Hundred Years of Solitude is a 1967 novel by Colombian author Gabriel García Márquez that tells the multi-generational story of the Buendía family, whose patriarch, José Arcadio Buendía, founded the fictitious town of Macondo. The novel is often cited as one of the supreme achievements in world literature.",
                    LanguageId = 1,
                    CreateOn = DateTime.Now,
                    UpdateOn = DateTime.Now,
                    CoverImageUrl = "/books/cover/op825708-23f6-4321-832a-ba21498ef5e2_images.jpg"
                },
                new Book
                {
                    Id = 5,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    TotalPages = 220,
                    Category = "Novel",
                    Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
                    LanguageId = 2,
                    CreateOn = DateTime.Now,
                    UpdateOn = DateTime.Now,
                    CoverImageUrl = "/books/cover/xc825708-23f6-4321-832a-ba21498ef5e2_images.jpg"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
