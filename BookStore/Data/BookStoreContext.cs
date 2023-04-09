using BookStore.Models;
using BookStore.Service;
using Entities.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IBookStoreDataSeedService _jsonFileService;

        public BookStoreContext(DbContextOptions<BookStoreContext> options, IBookStoreDataSeedService jsonFileService)
            : base(options)
        {
            _jsonFileService = jsonFileService;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookGallery> BookGalleries { get; set; }

        public DbSet<Language> Languages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new BookConfiguration(
                _jsonFileService.GetBookTitles(), 
                _jsonFileService.GetNames(), 
                _jsonFileService.GetSurnames(), 
                _jsonFileService.GetCoverImageNames()));
            builder.ApplyConfiguration(new BookGalleryConfiguration(
                _jsonFileService.GetGalleryImageNames(), 
                _jsonFileService.GetCoverImageNames()));
            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

            base.OnModelCreating(builder);
        }

    }
}
