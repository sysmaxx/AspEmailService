using EmailServiceLibrary.Models;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace EmailServiceLibrary.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailServiceOptions _options;

        public EmailService(IOptions<EmailServiceOptions> options)
        {
            _options = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public Task SendEmailAsync(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
