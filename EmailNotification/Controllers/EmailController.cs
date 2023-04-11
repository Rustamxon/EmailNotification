using EmailNotification.Models;
using EmailNotification.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmailNotification.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]

        public async Task<IActionResult> SendAsync(EmailMessage message)
        {
            await _emailService.SendAsync(message);
            return Ok();
        }
    }
}
