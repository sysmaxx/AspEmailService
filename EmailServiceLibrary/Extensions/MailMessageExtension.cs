using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace EmailServiceLibrary.Extensions
{
    internal static class MailMessageExtension
    {
        internal static void AddFileAttachments(this MailMessage mail, List<IFormFile> files)
        {
            files?
                .Where(file => file is not null)
                .ToList()
                .ForEach(file => mail.Attachments.Add(new Attachment(file.OpenReadStream(), file.FileName, file.ContentType)));
        }
    }
}
