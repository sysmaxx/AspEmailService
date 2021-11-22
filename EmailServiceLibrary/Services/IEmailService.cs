using EmailServiceLibrary.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmailServiceLibrary.Services
{
    public interface IEmailService : IDisposable
    {
        Task SendEmailAsync(Email email, CancellationToken cancellationToken = default);
    }
}
