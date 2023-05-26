using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly BookStoreContext _context;

        public LanguageRepository(BookStoreContext context) => _context = context;

        public async Task<List<LanguageModel>> GetLanguages()
        {
            return await _context.Languages
                                    .Select(language => new LanguageModel
                                    {
                                        Id = language.Id,
                                        Name = language.Name,
                                    })
                                    .ToListAsync();
        }
    }
}
