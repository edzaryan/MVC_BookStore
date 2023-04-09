using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        private readonly string[] _categories;

        public CategoryConfiguration(string[] categories) => _categories = categories;

        private List<Category> GetCategories()
        {
            List<Category> categoryList = new();

            for (int i=0; i < _categories.Length; i++)
            {
                categoryList.Add(new()
                {
                    Id = i + 1,
                    Name = _categories[i]
                });
            }

            return categoryList;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GetCategories());
        }
    }
}
