using BookStore.Models;

namespace BookStore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
        Task SendEmailForConfirmation(UserEmailOptions userEmailOptions);
        Task SendEmailForForgotPassword(UserEmailOptions userEmailOptions);
    }
}