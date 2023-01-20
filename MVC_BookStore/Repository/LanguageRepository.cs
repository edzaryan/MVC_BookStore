using Microsoft.EntityFrameworkCore;
using MVC_BookStore.Data;
using MVC_BookStore.Models;

namespace MVC_BookStore.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly AppDbContext _ctx;

        public LanguageRepository(AppDbContext context) => _ctx = context;

        public async Task<List<LanguageModel>> GetLanguages()
        {
            return _ctx.Languages.Select(l => new LanguageModel()
            {
                Id = l.Id,
                Name = l.Name,
            }).ToList();
        }
    }
}
