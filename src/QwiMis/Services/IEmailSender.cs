using System.Threading.Tasks;

namespace QwiMis.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}