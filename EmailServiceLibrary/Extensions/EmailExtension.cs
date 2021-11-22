using System.Linq;
using System.Net.Mail;
using EmailServiceLibrary.Models;

namespace EmailServiceLibrary.Extensions
{
    internal static class EmailExtension
    {
        internal static MailMessage ToMailMessage(this Email email)
        {
            var mail = new MailMessage
            {
                From = new MailAddress(email.From, email.DisplayName),
                Body = email.Body,
                Subject = email.Subject,
                BodyEncoding = email.Encoding,
                HeadersEncoding = email.Encoding,
                SubjectEncoding = email.Encoding,
                IsBodyHtml = email.IsHTML,
            };

            email.To.ToList().ForEach(to => mail.To.Add(to));
            email.BC?.ToList().ForEach(bc => mail.Bcc.Add(bc));
            email.CC?.ToList().ForEach(cc => mail.CC.Add(cc));

            return mail;
        }

    }
}
