using System.Net.Mail;
using EmailServiceLibrary.Models;

namespace EmailServiceLibrary.Extensions
{
    internal static class EmailExtension
    {
        internal static MailMessage ToMailMessage(this Email email, EmailServiceOptions _options)
        {
            var mail = new MailMessage
            {
                From = new MailAddress(_options.Email, _options.DisplayName),
                Body = email.Body,
                Subject = email.Subject,
                BodyEncoding = email.Encoding,
                HeadersEncoding = email.Encoding,
                SubjectEncoding = email.Encoding,
                IsBodyHtml = email.IsBodyHtml,
            };

            email.To?.ForEach(to => mail.To.Add(to));
            email.BC?.ForEach(bc => mail.Bcc.Add(bc));
            email.CC?.ForEach(cc => mail.CC.Add(cc));

            mail.AddFileAttachments(email.Attachments);

            return mail;
        }



    }
}
