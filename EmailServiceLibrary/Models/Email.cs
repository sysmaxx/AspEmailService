﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EmailServiceLibrary.Models
{
    public class Email
    {
        public string To { get; set; }
        public IEnumerable<string> CC { get; set; }
        public IEnumerable<string> BC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public IList<IFormFile> Attachments { get; set; }
        public bool IsHTML { get; set; } = false;
    }
}