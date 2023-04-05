using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new()
                {
                    Id = 1,
                    Name = "English"
                },
                new()
                {
                    Id = 2,
                    Name = "German"
                },
                new()
                {
                    Id = 3,
                    Name = "Russian"
                }
            );
        }
    }
}
