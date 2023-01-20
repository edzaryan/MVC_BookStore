namespace MVC_BookStore.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}