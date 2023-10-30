using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Services
{
    public interface IEmailSenderService
    {
        public void SendEmail(string fromEmail, string toEmail, string subject, string body);
        public Task SendEmailAsync(string fromEmail, string toEmail, string subject, string body);
        public Task SendConfirmationEmail(string fromEmail, string toEmail, string subject, string body);
    }
}
