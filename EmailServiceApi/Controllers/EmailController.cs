using EmailServiceLibrary.Models;
using EmailServiceLibrary.Services;
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

        [HttpGet("/send")]
        public async Task SendMail(CancellationToken cancellationToken)
        {

            var mail = new Email
            {
                To =  new List<string> { "tt@tt.de" },
                Subject = "Testmail",
                Body = "Just a short test",
            };

            await _emailService.SendEmailAsync(mail, cancellationToken)
                .ConfigureAwait(false);
        }

    }
}
