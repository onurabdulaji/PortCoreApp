using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Services
{
    public interface IEmailBuilderService
    {
        MimeMessage BuildEmail(string fromEmail, string toEmail, string subject, string body);
        MimeMessage BuildEmailConfirmation(string fromEmail, string toEmail, string subject, string body);
    }
}
