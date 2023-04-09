using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        private readonly string[] _languages;

        public LanguageConfiguration(string[] languages) => _languages = languages;

        private List<Language> GetLanguages()
        {
            

            return categoryList;
        }

        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(GetLanguages());
        }
    }
}
