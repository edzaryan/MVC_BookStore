using Entities.Models;
using System.Text.Json;

namespace BookStore.Service
{
    public class BookStoreDataSeedService : IBookStoreDataSeedService
    {
        private string[] names, surnames, bookTitles, coverImageNames, galleryImageNames;

        public BookStoreDataSeedService() 
        {
            using (var fs = new FileStream("C:\\Users\\Dell\\OneDrive\\Desktop\\MVC_BookStore\\BookStore\\BookStoreSeedData.json", FileMode.OpenOrCreate))
            {
                var model = JsonSerializer.Deserialize<BookStoreSeedDataModel>(fs);

                names = model.Names;
                surnames = model.Surnames;
                bookTitles = model.BookTitles;
                coverImageNames = model.CoverImageNames;
                galleryImageNames = model.GalleryImageNames;
            }
        }


        public string[] GetSurnames() => surnames;

        public string[] GetNames() => names;

        public string[] GetBookTitles() => bookTitles;

        public string[] GetCoverImageNames() => coverImageNames;

        public string[] GetGalleryImageNames() => galleryImageNames;

    }
}
