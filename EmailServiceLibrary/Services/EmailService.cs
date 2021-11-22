using EmailServiceLibrary.Extensions;
using EmailServiceLibrary.Models;
using Microsoft.Extensions.Options;
using System;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using static Helper.SmtpClientHelper;

namespace EmailServiceLibrary.Services
{
    public sealed class EmailService : IEmailService
    {
        private readonly EmailServiceOptions _options;
        private readonly SmtpClient _smtpClient;

        public EmailService(IOptions<EmailServiceOptions> options)
        {
            // ToDo validate cfg
            _options = options.Value ?? throw new ArgumentNullException(nameof(options));
            _smtpClient = CreateSmtpClient(_options);
        }

        public async Task SendEmailAsync(Email email, CancellationToken cancellationToken = default)
        {
            await _smtpClient
                .SendMailAsync(email.ToMailMessage(_options), cancellationToken)
                .ConfigureAwait(false);
        }


        public void Dispose()
        {
            if (_smtpClient is not null)
                _smtpClient.Dispose();
        }

    }
}
