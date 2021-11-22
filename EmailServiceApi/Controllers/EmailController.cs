using EmailServiceLibrary.Models;
using EmailServiceLibrary.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AspEmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {

        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }

        [HttpPost("/send")]
        public async Task SendMail(IFormFile file, CancellationToken cancellationToken)
        {

            // ToDo Add DTO + validation

            var mail = new Email
            {
                To =  new List<string> { "m.herkt@secret.net" },
                Subject = "Testmail",
                Body = "Just a short test",
                Attachments = new List<IFormFile> { file }
            };

            await _emailService.SendEmailAsync(mail, cancellationToken)
                .ConfigureAwait(false);
        }

    }
}
