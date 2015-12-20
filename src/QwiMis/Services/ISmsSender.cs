using System.Threading.Tasks;

namespace QwiMis.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}