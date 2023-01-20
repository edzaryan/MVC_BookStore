using MVC_BookStore.Models;

namespace MVC_BookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}