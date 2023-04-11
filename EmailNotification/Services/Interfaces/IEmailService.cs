using EmailNotification.Models;

namespace EmailNotification.Services.Interfaces
{
    public interface IEmailService 
    {
        Task SendAsync(EmailMessage message);
    }
}
