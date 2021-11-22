using EmailServiceLibrary.Models;
using System.Net;
using System.Net.Mail;

namespace Helper
{
    internal static class SmtpClientHelper
    {
        internal static SmtpClient CreateSmtpClient(EmailServiceOptions _options) => new(_options.Host, _options.Port)
        {
            Credentials = new NetworkCredential(_options.Account, _options.Password),
            EnableSsl = _options.Security
        };

    }
}
