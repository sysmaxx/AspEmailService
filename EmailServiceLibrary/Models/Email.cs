using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Models
{
    public record Email
    {
        /// <summary>
        /// E-Mail recipient
        /// </summary>
        public List<string> To { get; set; }
        /// <summary>
        /// carbon copy
        /// </summary>
        public List<string> CC { get; set; }
        /// <summary>
        /// Blind copy
        /// </summary>
        public List<string> BC { get; set; }
        /// <summary>
        /// Subject
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Body, could be HTML-Code
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Is body written in HTML.
        /// Default is false
        /// </summary>
        public bool IsBodyHtml { get; set; } = false;
        /// <summary>
        /// File-Attachments
        /// </summary>
        public List<IFormFile> Attachments { get; set; }
        /// <summary>
        /// Used Encoding for body, header and subject.
        /// Default is UTF8
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;
    }
}
