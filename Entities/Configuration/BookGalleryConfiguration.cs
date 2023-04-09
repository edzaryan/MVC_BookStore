using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class BookGalleryConfiguration : IEntityTypeConfiguration<BookGallery>
    {
        private readonly string[] _bookGalleryImageNames;
        private readonly string[] _bookCoverImageNames;

        public BookGalleryConfiguration(string[] bookGalleryImageNames, string[] bookCoverImageNames) {
            _bookGalleryImageNames = bookGalleryImageNames;
            _bookCoverImageNames = bookCoverImageNames;
        }

        private List<BookGallery> GetBookGallery()
        {
            List<BookGallery> bookGalleryList = new();

            int TargetId = 1;

            for (int i=1; i <= _bookCoverImageNames.Length; i++)
            {
                bookGalleryList.Add(new()
                {
                    Id = TargetId,
                    BookId = i,
                    Name = "X.jpeg",
                    URL = $"\\files\\books\\coverImages\\{_bookCoverImageNames[i-1]}"
                });

                TargetId++;

                for (int j=0; j < _bookGalleryImageNames.Length; j++)
                {
                    bookGalleryList.Add(new()
                    {
                        Id = TargetId,
                        BookId = i,
                        Name = "X.jpeg",
                        URL = $"\\files\\books\\galleryImages\\{_bookGalleryImageNames[j]}"
                    });

                    TargetId++;
                }
            }

            return bookGalleryList;
        }

        public void Configure(EntityTypeBuilder<BookGallery> builder)
        {
            builder.HasData(GetBookGallery());
        }
    }
}
