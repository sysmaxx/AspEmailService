using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Models
{
    public record Email
    {
        public string From { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<string> To { get; set; }
        public IEnumerable<string> CC { get; set; }
        public IEnumerable<string> BC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHTML { get; set; } = false;
        public IList<IFormFile> Attachments { get; set; }
        public Encoding Encoding { get; set; } = Encoding.UTF8;
    }
}
