namespace BookStore.Service
{
    public interface IBookStoreDataSeedService
    {
        string[] GetNames();
        string[] GetSurnames();
        string[] GetBookTitles();
        string[] GetCoverImageNames();
        string[] GetGalleryImageNames();
    }
}
