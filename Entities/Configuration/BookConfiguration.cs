using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Entities.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        private readonly string[] _bookTitles;
        private readonly string[] _names;
        private readonly string[] _surnames;
        private readonly string[] _coverImageNames;

        public BookConfiguration(string[] bookTitles, string[] names, string[] surnames, string[] coverImageNames)
        {
            _bookTitles = bookTitles;
            _names = names;
            _surnames = surnames;
            _coverImageNames = coverImageNames;
        }

        private List<Book> GetBooks()
        {
            List<Book> bookList = new();

            Random random = new();

            for (int i=0; i < _bookTitles.Length; i++)
            {
                bookList.Add(new()
                {
                    Id = i + 1,
                    Title = _bookTitles[i],
                    Author = _names[random.Next(0, _names.Length)] + " " + _surnames[random.Next(0, _surnames.Length)],
                    Description = $"{_bookTitles[i]} is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!",
                    TotalPage = random.Next(100, 800),
                    LanguageId = random.Next(1, 3),
                    CoverImageUrl = $"\\files\\books\\coverImages\\{_coverImageNames[i]}",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf"
                });
            }

            return bookList;
        }

        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(GetBooks());
        }
    }
}
