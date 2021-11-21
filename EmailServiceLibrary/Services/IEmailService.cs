using EmailServiceLibrary.Models;
using System.Threading.Tasks;

namespace EmailServiceLibrary.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(Email email);
    }
}
