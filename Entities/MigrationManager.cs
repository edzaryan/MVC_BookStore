using BookStore.Data;
using Microsoft.EntityFrameworkCore;
namespace BookStore
{
    public static class MigrationManager
    {
        //public static WebApplication MigrateDatabase(this WebApplication webApp)
        //{
        //    using (var scope = webApp.Services.CreateScope())
        //    {
        //        using (var appContext = scope.ServiceProvider.GetRequiredService<BookStoreContext>())
        //        {
        //            try
        //            {
        //                appContext.Database.Migrate();
        //            }
        //            catch (Exception ex)
        //            {

        //                throw;
        //            }
        //        }
        //    }

        //    return webApp;
        //}
    }
}
